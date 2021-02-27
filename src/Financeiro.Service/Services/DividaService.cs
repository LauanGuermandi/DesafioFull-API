using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Financeiro.Domain.Interfaces.Service;
using Financeiro.Domain.Models;

namespace Financeiro.Service.Services
{
    public class DividaService : IDividaService
    {
        private IRepository<Divida> _repository;
        
        private readonly IMapper _mapper;

        public DividaService(IRepository<Divida> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<DividaResultDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DividaResultDto>> GetByPessoaId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<DividaResultDto> Post(DividaDto divida)
        {
            var dividaModel = _mapper.Map<DividaModel>(divida);
            var dividaEntity = _mapper.Map<Divida>(dividaModel);

            var result = await _repository.InsertAsync(dividaEntity);

            return _mapper.Map<DividaResultDto>(result);
        }
    }
}
