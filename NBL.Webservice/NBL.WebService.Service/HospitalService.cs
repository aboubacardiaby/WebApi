using NBL.Webservice.DataAccess;
using NBL.WebService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.WebService.Service
{
    public class HospitalService : IHospitalService
    {
        private readonly Webservice.DataAccess.IRepository<Hostpital> _repository;
        public HospitalService(IRepository<Hostpital> repository)
        {
            _repository = repository;
        }

        public void AddNewHospital(Hostpital hospital)
        {
            _repository.Insert(hospital);
        }
    }
}
