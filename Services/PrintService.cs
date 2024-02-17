using PrintAPI.Adapters;

namespace PrintAPI.Services
{
    public class PrintService : IPrintService
    {
        private readonly IPrinterAdapter _printerAdapter;

        public PrintService(IPrinterAdapter printerAdapter)
        {
            _printerAdapter = printerAdapter;
        }

        public void printDocument(string ipAddress, string productName, string productWeight)
        {
            _printerAdapter.print(ipAddress,productName,productWeight);
        }
    }
}
