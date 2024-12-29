using Com.Ctk.Sdk;
using wms_android.Interfaces;

namespace wms_android.Services;

public class PosApiPrinterService : IPrinterService
{
    private readonly PosApiHelper _posApiHelper;

    public PosApiPrinterService()
    {
        _posApiHelper = PosApiHelper.Instance;
    }

    public void InitializePrinter()
    {
        int result = _posApiHelper.PrintInit(2, 2, 0, 0x00);
        if (result != 0)
            throw new Exception("Failed to initialize the printer.");
    }

    public void PrintText(string text, int align = 0, int fontSize = 1)
    {
        _posApiHelper.PrintSetAlign(align);
        _posApiHelper.PrintSetFont((sbyte)fontSize, (sbyte)fontSize, (sbyte)0x00);
        _posApiHelper.PrintStr(text);
    }

    public void PrintQRCode(string data, int width, int height)
    {
        _posApiHelper.PrintQrCode_Cut(data, width, height, "QR_CODE");
    }

    public void FinalizePrint()
    {
        _posApiHelper.PrintStart();
    }
}
