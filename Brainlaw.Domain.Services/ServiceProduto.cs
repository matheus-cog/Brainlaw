using Brainlaw.Domain.Core.Interfaces.Repositories;
using Brainlaw.Domain.Core.Interfaces.Services;
using Brainlaw.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Brainlaw.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }

        public IEnumerable<Produto> GetAll()
        {
            List<Produto> todosProdutos = new List<Produto>();
            var list = repositoryProduto.GetAll().ToList();

            list.ForEach(item => { 
                if(item.Status)
                    todosProdutos.Add(item);
            });

            return todosProdutos;
        }

        public Produto GetById(int id)
        {
            var produto = repositoryProduto.GetById(id);
            if (!produto.Status)
                return null;
            return produto;
        }
    }
}