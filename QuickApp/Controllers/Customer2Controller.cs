using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using Finbuckle.MultiTenant;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuickApp.Helpers;
using QuickApp.ViewModels;

namespace QuickApp.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = IdentityServerAuthenticationDefaults.AuthenticationScheme)]
    public class Customer2Controller : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IEmailSender _emailSender;


        public Customer2Controller(IMapper mapper, IUnitOfWork unitOfWork, ILogger<Customer2Controller> logger, IEmailSender emailSender)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _emailSender = emailSender;
        }



        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var allCustomers = _unitOfWork.Customers.GetAllCustomersData();
            return Ok(_mapper.Map<IEnumerable<CustomerViewModel>>(allCustomers));
        }

        [HttpGet("tenantinfo")]
        public IActionResult GetTenantInfo()
        {
            var ti = HttpContext.GetMultiTenantContext<ExtendedTenantInfo>()?.TenantInfo;
            string tiData = "NO TENANT!";
            if (ti != null)
            {
                tiData = "ID: " + ti.Id + Environment.NewLine + "Name: " + ti.Name + Environment.NewLine + "Connection String: " + ti.ConnectionString;
            }

            return Ok(tiData);
        }
    }
}
