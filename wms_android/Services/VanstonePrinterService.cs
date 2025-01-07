using System.Diagnostics;
using Android.Content;
using Android.App;
using Com.Vanstone.Trans.Api;
using wms_android.Interfaces;
using Application = Android.App.Application;

namespace wms_android.Services;

public class VanstonePrinterService : IPrinterService
{
    private readonly PrinterServiceConnection _connection;

    public VanstonePrinterService()
    {
        _connection = new PrinterServiceConnection();
        BindPrinterService();
    }

    private void BindPrinterService()
    {
        Intent intent = new Intent("com.vanstone.appsdk.api.printer.PrinterHandlerService");
        Application.Context.BindService(intent, _connection, Bind.AutoCreate);
    }

    public void InitializePrinter()
    {
        if (_connection.PrinterHandler == null)
        {
            throw new InvalidOperationException("PrinterHandler is not connected.");
        }

        int result = _connection.PrinterHandler.PrnOpen_Api();
        if (result < 0)
        {
            throw new Exception("Failed to open printer connection.");
        }
    }

    public void PrintText(string text, int align = 0, int fontSize = 1)
    {
        if (_connection.PrinterHandler == null)
        {
            throw new InvalidOperationException("PrinterHandler is not connected.");
        }

        _connection.PrinterHandler.PrintAddText_Api(fontSize, align, text);
    }

    public void PrintQRCode(string data, int width, int height)
    {
        if (_connection.PrinterHandler == null)
        {
            throw new InvalidOperationException("PrinterHandler is not connected.");
        }

        _connection.PrinterHandler.PrintAddQrCode_Api(1, width, data);
    }

    public void FinalizePrint()
    {
        if (_connection.PrinterHandler == null)
        {
            throw new InvalidOperationException("PrinterHandler is not connected.");
        }

        _connection.PrinterHandler.PrintStartPrint_Api();
        _connection.PrinterHandler.PrnClose_Api();
    }
}


