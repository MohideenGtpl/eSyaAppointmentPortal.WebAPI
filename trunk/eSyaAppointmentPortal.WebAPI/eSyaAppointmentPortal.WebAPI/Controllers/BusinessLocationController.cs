﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaAppointmentPortal.IF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSyaAppointmentPortal.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BusinessLocationController : ControllerBase
    {

        private readonly IBusinessLocationRepository _businessLocationRepository;

        public BusinessLocationController(IBusinessLocationRepository businessLocationRepository)
        {
            _businessLocationRepository = businessLocationRepository;
        }

        public async Task<IActionResult> GetBusinessLocation()
        {
            var ds = await _businessLocationRepository.GetBusinessLocation();
            return Ok(ds);
        }

        public async Task<IActionResult> GetBusinessLocationDetails(int businessKey)
        {
            var ds = await _businessLocationRepository.GetBusinessLocationDetails(businessKey);
            return Ok(ds);
        }
    }
}