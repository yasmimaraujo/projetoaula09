using ProjetoAula09.Entities;
using ProjetoAula09.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula09.Controllers
{
    public class ProdutoController
    {
        //Atributo para armazenar a connectionstring do banco de dados
        private string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_Projeto09;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Método para realizar o cadastro do produto
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE PRODUTO\n");

                var produto = new Produto();

                Console.Write("Entre com o nome do produto..............: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Entre com o preço do produto.............: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto........: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("Entre com a data de validade do produto..: ");
                produto.DataValidade = DateTime.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.ConnectionString = connectionstring;

                //Gravar produto no banco de dados
                produtoRepository.Inserir(produto);

                Console.WriteLine("\nProduto cadastrado com sucesso !");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }
}
