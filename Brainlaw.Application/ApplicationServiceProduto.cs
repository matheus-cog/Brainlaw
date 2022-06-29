using AutoMapper;
using Brainlaw.Application.DTO;
using Brainlaw.Application.Interfaces;
using Brainlaw.Domain.Core.Interfaces.Services;
using Brainlaw.Domain.Models;
using System.Collections.Generic;

namespace Brainlaw.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapper mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto
                                        , IMapper mapper)
        {
            this.serviceProduto = serviceProduto;
            this.mapper = mapper;
        }

        public void Add(ProdutoDTO ProdutoDTO)
        {
            var produto = mapper.Map<Produto>(ProdutoDTO);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            var produtosDTO = mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
            return produtosDTO;
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            var ProdutoDTO = mapper.Map<ProdutoDTO>(produto);        
            return ProdutoDTO;
        }

        public void Remove(ProdutoDTO ProdutoDTO)
        {
            var produto = mapper.Map<Produto>(ProdutoDTO);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO ProdutoDTO)
        {
            var produto = mapper.Map<Produto>(ProdutoDTO);
            serviceProduto.Update(produto);
        }
    }
}