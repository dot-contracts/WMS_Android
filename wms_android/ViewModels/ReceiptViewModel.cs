using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wms_android.data.Models;
using wms_android.data.Interfaces;
using System.Collections.ObjectModel;
using wms_android.Interfaces;

namespace wms_android.ViewModels;

    public class ReceiptViewModel : INotifyPropertyChanged
    {
        private readonly IParcelService _parcelService;
        private readonly IPrinterService _printerService;

        public ObservableCollection<Parcel> Parcels { get; set; }
        public ObservableCollection<string> PaymentMethods { get; set; } = new();

        public string WaybillNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private Parcel _parcel;
        public Parcel Parcel
        {
            get => _parcel;
            set
            {
                if (_parcel != value)
                {
                    _parcel = value;
                    OnPropertyChanged(nameof(Parcel));
                }
            }
        }

        public ICommand PrintReceiptCommand { get; }
        public ICommand PrintCartReceiptCommand { get; }

        public ReceiptViewModel(IParcelService parcelService, IPrinterService printerService)
        {
            _parcelService = parcelService;
            _printerService = printerService;

            PrintReceiptCommand = new Command(async () => await PrintReceipt());
            PrintCartReceiptCommand = new Command(async () => await PrintCartReceipt());

            Parcels = new ObservableCollection<Parcel>();

            InitializePrinter();
        }

        private void InitializePrinter()
        {
            try
            {
                _printerService.InitializePrinter();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Printer initialization failed: {ex.Message}");
            }
        }

        private async Task PrintReceipt()
        {
            try
            {
                // Print header
                _printerService.PrintText("Ficma Home Logistics\n", align: 1, fontSize: 2);
                _printerService.PrintText("0707136852\n", align: 1);
                _printerService.PrintText("ficmahomelogistics19@gmail.com\n", align: 1);
                _printerService.PrintText("---- Receipt ----\n", align: 1);

                // Print parcel details
                _printerService.PrintText($"Waybill Number: {Parcel.WaybillNumber}\n", align: 0);
                _printerService.PrintText($"Sender: {Parcel.Sender}\n", align: 0);
                _printerService.PrintText($"Receiver: {Parcel.Receiver}\n", align: 0);
                _printerService.PrintText($"Destination: {Parcel.Destination}\n", align: 0);
                _printerService.PrintText($"Payment Method: {Parcel.PaymentMethods}\n", align: 0);

                // Print total amount
                _printerService.PrintText($"Total Amount: Ksh {Parcel.TotalAmount:N2}\n", align: 1, fontSize: 2);

                // Print QR code
                _printerService.PrintQRCode(Parcel.WaybillNumber, width: 360, height: 360);

                // Print disclaimer
                _printerService.PrintText("NB:\n", align: 0);
                _printerService.PrintText("Contents not checked. Customers are advised to insure their goods.\n", align: 0);

                _printerService.FinalizePrint();

                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");

                await Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Printing error: {ex.Message}");
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Error", $"Failed to print receipt: {ex.Message}", "OK");

                // Attempt to reinitialize the printer if needed
                try
                {
                    _printerService.InitializePrinter();
                }
                catch (Exception initEx)
                {
                    Debug.WriteLine($"Reinitialization failed: {initEx.Message}");
                }
            }
        }

        private async Task PrintCartReceipt()
        {
            try
            {
                // Print header
                _printerService.PrintText("Ficma Home Logistics - Cart Receipt\n", align: 1, fontSize: 2);
                _printerService.PrintText("0707136852\n", align: 1);
                _printerService.PrintText("ficmahomelogistics19@gmail.com\n", align: 1);
                _printerService.PrintText("---- Cart Receipt ----\n", align: 1);

                // Print waybill and total
                _printerService.PrintText($"Waybill Number: {WaybillNumber}\n", align: 0);
                _printerService.PrintText($"Total Amount for Cart: Ksh {TotalAmount:N2}\n", align: 0);
                _printerService.PrintText($"Payment Method: {PaymentMethod}\n", align: 0);

                // Print each parcel
                foreach (var parcel in Parcels)
                {
                    _printerService.PrintText($"Parcel ID: {parcel.Id}\n", align: 0);
                    _printerService.PrintText($"Sender: {parcel.Sender}\n", align: 0);
                    _printerService.PrintText($"Receiver: {parcel.Receiver}\n", align: 0);
                    _printerService.PrintText($"Destination: {parcel.Destination}\n", align: 0);
                    _printerService.PrintText($"Amount: Ksh {parcel.Amount:N2}\n", align: 0);
                    _printerService.PrintText("----\n", align: 0);
                }

                // Print QR code for the waybill
                _printerService.PrintQRCode(WaybillNumber, width: 360, height: 360);

                // Print disclaimer
                _printerService.PrintText("NB:\n", align: 0);
                _printerService.PrintText("Contents not checked. Customers are advised to insure their goods.\n", align: 0);

                _printerService.FinalizePrint();

                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Success", "Cart receipt printed successfully.", "OK");

                await Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Cart printing error: {ex.Message}");
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Error", $"Failed to print cart receipt: {ex.Message}", "OK");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }