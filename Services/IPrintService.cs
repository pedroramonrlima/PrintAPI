namespace PrintAPI.Services
{
    public interface IPrintService
    {
        void printDocument(string ipAddress, string productName, string productWeight);
    }
}