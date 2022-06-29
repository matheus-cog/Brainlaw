using Brainlaw.Application.DTO;
using System.Collections.Generic;

namespace Brainlaw.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO ProdutoDTO);

        void Update(ProdutoDTO ProdutoDTO);

        void Remove(ProdutoDTO ProdutoDTO);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(int id);
    }
}