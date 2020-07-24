using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMS_Domain.Entities;
using LIMS_Domain.Interfaces.Repositories;

namespace LIMS_Infra.Repositories
{
    public class AmostraMemDB : IAmostraRepository
    {
        public ICollection<Amostra> Amostras = new List<Amostra>();

        public bool Create(Amostra entity)
        {
            Amostras.Add(entity);
            return true;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Amostra Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Amostra> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Amostra entity)
        {
            throw new NotImplementedException();
        }
    }
}
