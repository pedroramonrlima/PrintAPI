namespace PrintAPI.Adapters
{
    public interface IPrinterAdapter
    {
        void print(string ipAddress, string productName, string productWeight);
    }
}