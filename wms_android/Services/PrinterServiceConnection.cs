using Android.Content;
using Android.OS;
using Com.Vanstone.Appsdk.Api.Printer;
using Debug = System.Diagnostics.Debug;

namespace wms_android.Services;

public class PrinterServiceConnection : Java.Lang.Object, IServiceConnection
{
    public IPrinterHandler PrinterHandler { get; private set; }

    public void OnServiceConnected(ComponentName name, IBinder service)
    {
        PrinterHandler = IPrinterHandler.Stub.AsInterface(service);
        Debug.WriteLine("Service connected.");
    }

    public void OnServiceDisconnected(ComponentName name)
    {
        PrinterHandler = null;
        Debug.WriteLine("Service disconnected.");
    }
}
