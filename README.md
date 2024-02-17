**PrintAPI:** WebAPI de Impressão de Etiqueta ZPL

**Descrição:**
Este projeto é uma Web API desenvolvida em C# que simplifica o processo de impressão de etiquetas ZPL pré-definidas. A API recebe parâmetros como o endereço IP da impressora, nome do produto e peso do produto em quilogramas, permitindo uma integração fácil e rápida em seu aplicativo.

**Como Executar a Aplicação:**
1. Clone o repositório em sua máquina local:
    `git clone https://github.com/darklinnux/PrintAPI.git`
2. Navegue até o diretório do projeto:
    `cd nome-do-repositorio`
3. Restaure as dependências do projeto:
    `dotnet restore`
4. Execute a aplicação:
    `dotnet run`


**Endpoints Disponíveis:**
1. **Imprimir Etiqueta:**
- Método: POST
- Endpoint: `http://localhost:5244/api/print`
- Parâmetros no corpo da solicitação:
  ```
  {
      "IPAddress": "Endereço IP da Impressora",
      "ProductName": "Nome do Produto",
      "ProductWeight": "Peso do Produto (kg)"
  }
  ```
**Como Contribuir:**
1. Faça um fork do repositório.
2. Implemente suas melhorias ou correções.
3. Envie um pull request para revisão.

**Tecnologia Utilizada:**
- C#
- ASP.NET Web API

**Link do Repositório:** https://github.com/darklinnux/PrintAPI.git

Junte-se a mim neste projeto e simplifique seu processo de impressão de etiquetas! 🏷️💻 #GitHub #OpenSource #WebAPI #CSharp #ZPL #ImpressãoEtiqueta
