using ColegioVRHT.BusinessLogic.Interface;
using ColegioVRHT.Entities;
using ColegioVRHT.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.BusinessLogic.Implementation
{
    public class PersonBusinessLogic : BusinessLogicBase<Persona>, IPersonBusinessLogic
    {
        public readonly IPersonRepository _IPersonRepository;
        public PersonBusinessLogic(IPersonRepository _IPersonRepository)
            : base(_IPersonRepository)

        {
            this._IPersonRepository = _IPersonRepository;
        }
    }
}
