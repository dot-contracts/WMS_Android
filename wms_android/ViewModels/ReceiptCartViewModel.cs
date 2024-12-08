using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Interfaces;
using wms_android.data.Models;
using Com.Ctk.Sdk;
using wms_android.Interfaces;

namespace wms_android.ViewModels
{
    // ReceiptViewModel
    public class ReceiptCartViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private PosApiHelper _posApiHelper;

        public ObservableCollection<Parcel> Parcels { get; set; }

        public string WaybillNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand PrintCartReceiptCommand { get; }

        public ReceiptCartViewModel(IParcelService parcelService, ObservableCollection<Parcel> parcels, string waybillNumber, decimal totalAmount, string paymentMethod)
        {
            _parcelService = parcelService;
            Parcels = parcels;
            WaybillNumber = waybillNumber;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;

            PrintCartReceiptCommand = new Command(async (obj) => await PrintCartReceipt());

            // Initialize PosApiHelper
            _posApiHelper = PosApiHelper.Instance;
            InitializePrinter();
        }

        private void InitializePrinter()
        {
            int gray = 2;
            int density = 2;
            int mode = 0;
            int otherOptions = 0x00;

            int result = _posApiHelper.PrintInit(gray, density, mode, otherOptions);
            if (result != 0)
            {
                Console.WriteLine("Failed to initialize printer.");
            }
        }

        private async Task PrintCartReceipt()
        {
            try
            {
                // Print header
                _posApiHelper.PrintSetAlign(1);
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x33);
                _posApiHelper.PrintStr("Ficma Home Logistics - Cart Receipt\n");

                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr("0707136852\n");
                _posApiHelper.PrintStr("ficmahomelogistics19@gmail.com\n");
                _posApiHelper.PrintStr("---- Cart Receipt ----\n");

                // Print waybill number and total amount for cart
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintSetFont((sbyte)8, (sbyte)8, (sbyte)0x00);
                _posApiHelper.PrintStr($"Waybill Number: {WaybillNumber}\n");
                _posApiHelper.PrintStr($"Total Amount for Cart: Ksh {TotalAmount:N2}\n");
                _posApiHelper.PrintStr($"Payment Method: {PaymentMethod}\n");

                // Iterate over each parcel in the cart and print details
                foreach (var parcel in Parcels)
                {
                    _posApiHelper.PrintStr("----\n");  // Separator for each parcel
                    _posApiHelper.PrintStr($"Parcel ID: {parcel.Id}\n");
                    _posApiHelper.PrintStr($"Sender: {parcel.Sender}\n");
                    _posApiHelper.PrintStr($"Receiver: {parcel.Receiver}\n");
                    _posApiHelper.PrintStr($"Destination: {parcel.Destination}\n");
                    _posApiHelper.PrintStr($"Rate: {parcel.Rate}\n");
                    _posApiHelper.PrintStr($"Amount: Ksh {parcel.Amount:N2}\n");
                }

                // Print a QR code for the entire cart waybill number
                _posApiHelper.PrintSetAlign(1);
                _posApiHelper.PrintQrCode_Cut(WaybillNumber, 360, 360, "QR_CODE");

                // Print disclaimer
                _posApiHelper.PrintSetFont((sbyte)16, (sbyte)16, (sbyte)0x00);
                _posApiHelper.PrintSetAlign(0);
                _posApiHelper.PrintStr("NB:\n");
                _posApiHelper.PrintStr("Contents not checked. \n");
                _posApiHelper.PrintStr("Customers are advised to insure their goods if the value exceeds Ksh 500. \n");
                _posApiHelper.PrintStr("All mirrors/boards are carried at owner's risk. \n");
                _posApiHelper.PrintStr("Cash is not accepted as a courier, and the company will not be held liable.\n");

                // Add extra space and finish printing
                _posApiHelper.PrintFeedPaper(150);
                _posApiHelper.PrintStart();

                await Application.Current.MainPage.DisplayAlert("Success", "Cart receipt printed successfully.", "OK");

                // Navigate back to the root view
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cart Printing Error: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to print cart receipt: {ex.Message}", "OK");
            }
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("Parcels"))
                Parcels = new ObservableCollection<Parcel>((List<Parcel>)query["Parcels"]);

            if (query.ContainsKey("WaybillNumber"))
                WaybillNumber = query["WaybillNumber"].ToString();

            if (query.ContainsKey("TotalAmount"))
                TotalAmount = (decimal)query["TotalAmount"];

            if (query.ContainsKey("PaymentMethod"))
                PaymentMethod = query["PaymentMethod"].ToString();

            // Notify any UI elements bound to these properties to refresh
            OnPropertyChanged(nameof(Parcels));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(TotalAmount));
            OnPropertyChanged(nameof(PaymentMethod));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
