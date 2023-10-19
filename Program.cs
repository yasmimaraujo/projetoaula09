using ProjetoAula09.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula09
{
     class Program
    {
        static void Main(string[] args)
        {
            //Chamar o controlador e executar o cadastro de produto...
            var produtoController = new ProdutoController();
            produtoController.CadastrarProduto();

            Console.ReadKey();

        }
    }
}
