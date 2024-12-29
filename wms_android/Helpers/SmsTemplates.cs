namespace wms_android.Helpers;

public class SmsTemplates
{
    public static string ParcelDispatched(string waybillNumber, string sender, string senderPhone, string destination, decimal totalAmount, string paymentMethod)
    {
        return $"Your parcel (Waybill: {waybillNumber}) has been dispatched from {sender} ({senderPhone}) to {destination}. Total Amount: {totalAmount:C} (Payment: {paymentMethod}).";
    }

    public static string WaybillFinalized(string waybillNumber, int parcelCount, decimal totalAmount, string paymentMethod)
    {
        return $"Your waybill (No: {waybillNumber}) containing {parcelCount} parcels has been finalized. Total Amount: {totalAmount:C} (Payment: {paymentMethod}).";
    }
}