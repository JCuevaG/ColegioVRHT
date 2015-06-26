using ColegioVRHT.BusinessLogic.Interface;
using ColegioVRHT.Entities;
using ColegioVRHT.Repository.Implementation;
using ColegioVRHT.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.BusinessLogic.Implementation
{
    public class SexoBusinessLogic : BusinessLogicBase<Sexo>, ISexoBusinessLogic
    {

        public readonly ISexoRepository _IEstadoCivilRepository;

        public SexoBusinessLogic(ISexoRepository _IEstadoCivilRepository)
            : base(_IEstadoCivilRepository)
        {
            this._IEstadoCivilRepository = _IEstadoCivilRepository;
        }

        //public IEnumerable<EstadoCivil> GetAll()
        //{
        //    return _IEstadoCivilRepository.GetAll();
        //}
    }
}
