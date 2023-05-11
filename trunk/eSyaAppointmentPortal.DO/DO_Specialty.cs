using System;
using System.Collections.Generic;
using System.Text;

namespace eSyaAppointmentPortal.DO
{
    public class DO_Specialty
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyDescription { get; set; }

        public bool IsTopSpecialty { get; set; }
        public string MedicalIcon { get; set; }
    }
    public class DO_ClinicType
    {
        public int ClinicType { get; set; }
        public string ClinicTypeCode { get; set; }
        public string ClinicTypeDesc { get; set; }
        public int ConsultationType { get; set; }
        public string ConsultationTypeCode { get; set; }
        public string ConsultationTypeDesc { get; set; }
    }
}
