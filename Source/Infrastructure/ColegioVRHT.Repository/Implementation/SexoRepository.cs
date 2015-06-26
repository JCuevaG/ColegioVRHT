using ColegioVRHT.Entities;
using ColegioVRHT.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.Repository.Implementation
{
    public class SexoRepository : RepositoryBase<Sexo,ColegioVRHTContext> , ISexoRepository
    {

        //ColegioVRHTContext context = new ColegioVRHTContext();

        public SexoRepository(ColegioVRHTContext context)
            : base(context)
        {

        }

        //public IEnumerable<EstadoCivil> GetAll()
        //{
            //return context.Database.SqlQuery<EstadoCivil>("Maestro.USP_SEL_ESTADOCIVIL");
                
        //}
    }
}
