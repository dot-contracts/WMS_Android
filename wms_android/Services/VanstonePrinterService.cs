using Com.Vanstone.Trans.Api;
using wms_android.Interfaces;

namespace wms_android.Services;

public class VanstonePrinterService : IPrinterService
{
    public void InitializePrinter()
    {
        int result = PrinterApi.PrintEnd_Api();
        if (result < 0)
            throw new Exception("Failed to initialize the printer.");
    }

    public void PrintText(string text, int align = 0, int fontSize = 1)
    {
        PrinterApi.PrintSetAlign_Api(align);
        PrinterApi.PrintAddText_Api(fontSize, align, text);
    }

    public void PrintQRCode(string data, int width, int height)
    {
        PrinterApi.PrintAddQrCode_Api(1, width, data);
    }

    public void FinalizePrint()
    {
        PrinterApi.PrintStartPrint_Api();
    }
}
