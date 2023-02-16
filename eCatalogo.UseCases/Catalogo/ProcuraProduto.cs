using eCatalogo.Core.Entities;
using eCatalogo.UseCases.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalogo.UseCases.Catalogo
{
    public class ProcuraProduto : IProcuraProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public ProcuraProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> Execute(string filter = null)
        {
            return produtoRepository.GetProdutos(filter);
        }
    }
}
