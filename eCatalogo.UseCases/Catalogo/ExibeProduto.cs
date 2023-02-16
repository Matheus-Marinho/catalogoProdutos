using eCatalogo.Core.Entities;
using eCatalogo.UseCases.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalogo.UseCases.Catalogo
{
    public class ExibeProduto : IExibeProduto
    {
        private readonly IProdutoRepository produtoRepository;

        public ExibeProduto(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public Produto Execute(int id)
        {
            return produtoRepository.GetProduto(id);
        }
    }
}
