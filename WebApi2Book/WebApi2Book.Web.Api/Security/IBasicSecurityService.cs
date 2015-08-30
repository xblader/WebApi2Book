using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Book.Web.Api.Security
{
    public interface IBasicSecurityService
    {
        bool SetPrincipal(string username, string password);
    }
}