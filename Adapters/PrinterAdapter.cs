using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace PrintAPI.Adapters
{
    public class PrinterAdapter : IPrinterAdapter
    {
        private String prnFilePath;
        public PrinterAdapter(){
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.prnFilePath = Path.Combine(projectDirectory, "zpl_model.prn");
        }
        public void print(string ipAddress, string productName, string productWeight)
        {
            try
            {
                // Crie um socket TCP
                using (TcpClient client = new TcpClient(ipAddress, 9100))
                {
                    using (StreamWriter writer = new StreamWriter(client.GetStream()))
                    {
                        
                        string text = File.ReadAllText(this.prnFilePath);

                        text = text.Replace("{produto}", productName);

                        text = text.Replace("{peso}", productWeight);
                        
                        byte[] data = Encoding.UTF8.GetBytes(text);

                        
                        client.GetStream().Write(data, 0, data.Length);

                        
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                throw new FileNotFoundException("Arquivo PRN não encontrado.", e.Message);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao imprimir: {ex.Message}");
            }
        }
    }
}
