using eCatalogo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalogo.UseCases.Interfaces.Repository
{
    public interface IProdutoRepository
    {
        Produto GetProduto(int id);
        IEnumerable<Produto> GetProdutos(string filter = null);
    }
}
