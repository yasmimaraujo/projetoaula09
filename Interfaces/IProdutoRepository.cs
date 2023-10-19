using ProjetoAula09.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula09.Interfaces
{
    public interface IProdutoRepository
    {
        void Inserir(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(Produto produto);
        List<Produto> ObterTodos();
        Produto ObterPorId(int idProduto);
    }
}
