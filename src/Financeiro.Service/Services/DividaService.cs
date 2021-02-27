using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Exceptions;
using Financeiro.Domain.Interfaces.Repository;
using Financeiro.Domain.Interfaces.Service;
using Financeiro.Domain.Models;

namespace Financeiro.Service.Services
{
    public class DividaService : IDividaService
    {
        private readonly IDividaRepository _dividaRepository;

        private readonly IMapper _mapper;

        public DividaService(IDividaRepository dividaRepository, IMapper mapper)
        {
            _dividaRepository = dividaRepository;
            _mapper = mapper;
        }

        public async Task<DividaCalculadaDto> Get(Guid id)
        {
            var divida = await _dividaRepository.GetDividaCalculada(id);
            var dividaCalculada = _mapper.Map<DividaCalculadaDto>(divida);

            dividaCalculada.Multa = divida.ValorOriginal * (Convert.ToDouble(divida.PorcentagemMulta) / 100.0);

            foreach (var parcela in dividaCalculada.Parcelas)
            {
                parcela.DiasAtrasado = (int) DateTime.UtcNow.Subtract(parcela.DataVencimento).TotalDays;
                
                if (parcela.DiasAtrasado <= 0) {
                    throw new InconsistentDataException("Erro ao calcular dias em atraso.");
                }

                parcela.Juros = ((Convert.ToDouble(divida.PorcentagemJuros) / 100.0) / 30.0) * parcela.DiasAtrasado;
                parcela.ValorAtualizado = (parcela.Juros + parcela.ValorOriginal);
            }

            return dividaCalculada;
        }

        public async Task<IEnumerable<DividaResultDto>> GetByPessoaId(Guid id)
        {
            var listEntity = await _dividaRepository.GetDividasByPessoaId(id);
            return _mapper.Map<IEnumerable<DividaResultDto>>(listEntity);
        }

        public async Task<DividaResultDto> Post(DividaDto divida)
        {
            var dividaModel = _mapper.Map<DividaModel>(divida);
            var dividaEntity = _mapper.Map<Divida>(dividaModel);

            var result = await _dividaRepository.InsertAsync(dividaEntity);

            return _mapper.Map<DividaResultDto>(result);
        }
    }
}
