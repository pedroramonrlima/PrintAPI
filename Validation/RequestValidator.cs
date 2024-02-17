using PrintAPI.Models;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace PrintAPI.Validation
{
    public static class RequestValidator
    {
        public static bool ValidatePrintRequest(PrintRequest request, out string errorMessage)
        {
            errorMessage = null;

            if (request == null)
            {
                errorMessage = "Solicitação nula.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(request.IPAddress) || !IsValidIPAddress(request.IPAddress))
            {
                errorMessage = "Endereço IP da impressora inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(request.ProductName))
            {
                errorMessage = "Nome do Produto não fornecido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(request.ProductWeight))
            {
                errorMessage = "Peso do Produto não fornecido.";
                return false;
            }

            return true;
        }

        private static bool IsValidIPAddress(string ipAddress)
        {
            IPAddress address;
            return IPAddress.TryParse(ipAddress, out address);
        }
    }
}
