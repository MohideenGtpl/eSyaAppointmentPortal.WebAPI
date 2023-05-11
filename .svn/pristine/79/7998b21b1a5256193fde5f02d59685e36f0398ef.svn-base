using eSyaAppointmentPortal.DL.Entities;
using eSyaAppointmentPortal.DO;
using eSyaAppointmentPortal.IF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSyaAppointmentPortal.DL.Repository
{
    public class PatientInfoRepository : IPatientInfoRepository
    {
        private eSyaEnterpriseContext _context { get; set; }
        public PatientInfoRepository(eSyaEnterpriseContext context)
        {
            _context = context;
        }
        public async Task<List<DO_PatientInfo>> GetPatientInfoByMobileNumber(int businessKey, string mobileNumber)
        {
            //using (var db = new eSyaEnterpriseContext())
            //{
            try { 
                var pm = await _context.GtEfoppr
                    .Where(w => w.MobileNumber.ToString() == mobileNumber && w.ActiveStatus)
                    .AsNoTracking()
                    .Select(r => new DO_PatientInfo
                    {
                        UHID = r.RUhid,
                        PatientId = r.PatientId,
                        FirstName = r.FirstName,
                        LastName = r.LastName,
                        Gender = r.Gender,
                        DateOfBirth = r.DateOfBirth,
                        MobileNumber = r.MobileNumber,
                        EmailId = r.EMailId,
                        // CustomerId = r.CustomerId

                    }).ToListAsync();

                return pm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //}
        }

        public async Task<DO_PatientInfo> GetPatientInfoByUHID(int businessKey, int UHID)
        {
            //using (var db = new eSyaEnterpriseContext())
            //{
            try
            {
                var pm = await _context.GtEfoppr
                    .Where(w => w.RUhid == UHID && w.ActiveStatus)
                    .AsNoTracking()
                    .Select(r => new DO_PatientInfo
                    {
                        UHID = r.RUhid,
                        PatientId = r.PatientId,
                        FirstName = r.FirstName,
                        LastName = r.LastName,
                        Gender = r.Gender,
                        DateOfBirth = r.DateOfBirth,
                        MobileNumber = r.MobileNumber,
                        EmailId = r.EMailId,
                        // CustomerId = r.CustomerId

                    }).FirstOrDefaultAsync();

                return pm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //}
        }
    }
}
