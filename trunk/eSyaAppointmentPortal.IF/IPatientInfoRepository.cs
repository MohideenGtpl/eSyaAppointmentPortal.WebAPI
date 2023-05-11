﻿using eSyaAppointmentPortal.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaAppointmentPortal.IF
{
    public interface IPatientInfoRepository
    {
        Task<List<DO_PatientInfo>> GetPatientInfoByMobileNumber(int businessKey, string mobileNumber);

        Task<DO_PatientInfo> GetPatientInfoByUHID(int businessKey, int UHID);
    }
}
