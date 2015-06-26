using ColegioVRHT.Entities;
using ColegioVRHT.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.Repository.Implementation
{
    public class PersonRepository : RepositoryBase<Persona, ColegioVRHTContext>, IPersonRepository
    {

        public PersonRepository(ColegioVRHTContext context)
            :base(context)
        {

        }
    }
}
