using GestaoEscolar.DTOs;
using GestaoEscolar.Models;
using System.Collections.Generic;
using System.Linq;
namespace GestaoEscolar.GatWay
{
    public class EscolaGateway
    {
        AppDbContext dbContext = new AppDbContext();

        public List<Escola> Listar(FiltroEscolaDTO filtroEscolaDTO)
        {
            IQueryable<Escola> iQueryable = dbContext.Escolas
                .Where(x => !string.IsNullOrWhiteSpace(filtroEscolaDTO.Nome) ? x.Nome.Contains(filtroEscolaDTO.Nome) : true);

            List<Escola> escolaDTO = iQueryable.ToList();
            return escolaDTO;
        }
    }
}
