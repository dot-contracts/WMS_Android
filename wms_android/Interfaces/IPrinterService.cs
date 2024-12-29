namespace wms_android.Interfaces;

public interface IPrinterService
{
    void InitializePrinter();
    void PrintText(string text, int align = 0, int fontSize = 1);
    void PrintQRCode(string data, int width, int height);
    void FinalizePrint();
}
