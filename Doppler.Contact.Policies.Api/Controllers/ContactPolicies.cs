using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using doppler_contact_policies_api.DopplerSecurity;
using Microsoft.AspNetCore.Authorization;

namespace doppler_contact_policies_api.Controllers
{
    [Authorize]
    [ApiController]
    public class ContactPolicies : ControllerBase
    {
        [Authorize(Policies.OWN_RESOURCE_OR_SUPERUSER)]
        [HttpGet("/accounts/{accountName}/settings")]
        public string GetContactPoliciesSettings(string accountName)
        {
            return $"Hello! \"you\" that have access to the account with accountName '{accountName}'";
        }
    }
}
