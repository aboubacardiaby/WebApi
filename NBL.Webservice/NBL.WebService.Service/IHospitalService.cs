﻿using NBL.WebService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.WebService.Service
{
    public interface IHospitalService
    {
        void AddNewHospital(Hostpital hospital);
        Hostpital GetHospital(string Id);
    }
}
