using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMS_Domain.Entities;
using LIMS_Domain.Interfaces.Repositories;

namespace LIMS_Domain.Services
{
    public class AmostraService
    {
        protected IAmostraRepository _amostraRepository;

        public AmostraService(IAmostraRepository amostraRepository)
        {
            _amostraRepository = amostraRepository;
        }

        public bool AdicionarAmostra(Amostra sample)
        {
            
            if (sample.DataColeta > DateTime.Now)
                return false;

            
            sample.Id = Guid.NewGuid();

            return _amostraRepository.Create(sample);
        }

        public Amostra ObterAmostra(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Amostra> ObterAmostras()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Amostra> ObterAmostrasPorCodigo(Amostra codAtleta)
        {
            throw new NotImplementedException();
        }
    }
}
