using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AutoMapper;
using Financeiro.Domain.Dtos.PessoaDtos;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Exceptions;
using Financeiro.Domain.Interfaces.Repository;
using Financeiro.Domain.Interfaces.Service;
using Financeiro.Domain.Models;

namespace Financeiro.Service.Services {
    public class PessoaService : IPessoaService {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaService(
            IPessoaRepository pessoaRepository,
            IMapper mapper) {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public async Task<PessoaDto> Get(Guid Id) {
            var entity = await _pessoaRepository.SelectAsync(Id);
            return _mapper.Map<PessoaDto>(entity);
        }

        public async Task<IEnumerable<PessoaDto>> GetAll() {
            var listEntity = await _pessoaRepository.SelectAsync();
            return _mapper.Map<IEnumerable<PessoaDto>>(listEntity);
        }

        public async Task<PessoaDto> Post(PessoaCreateDto pessoa) {
            bool exists = await _pessoaRepository.ExistAsync(pessoa.CPF);

            if (exists)
                throw new DuplicatedValueException("CPF", "CPF já cadastrado.");


            var model = _mapper.Map<PessoaModel>(pessoa);
            var entity = _mapper.Map<Pessoa>(model);
            var result = await _pessoaRepository.InsertAsync(entity);

            return _mapper.Map<PessoaDto>(result);
        }
    }
}

