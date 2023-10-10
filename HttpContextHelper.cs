
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting
{
    public static class HttpContextHelper
    {
        /// <summary>
        /// 获取请求客户端的ip
        /// </summary>
        public static string GetRemoteIp(this HttpContext context)
        {
            return context.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

        /// <summary>
        /// 获取当前应用名
        /// </summary>
        public static string GetCurrentClientId(this HttpContext context)
        {
            return context.User.Claims.Where((Claim e) => e.Type == "client_id").FirstOrDefault()?.Value;
        }

        /// <summary>
        /// 获取当前应用名
        /// </summary>
        public static string GetCurrentUserName(this HttpContext context)
        {
            return context.User.Identity.Name;
        }

        /// <summary>
        /// 获取认证提供器名称
        /// </summary>
        public static string GetCurrentIdentityProvider(this HttpContext context)
        {
            return context.User.Claims.Where((Claim e) => e.Type == "http://schemas.microsoft.com/identity/claims/identityprovider").FirstOrDefault()?.Value;
        }

        /// <summary>
        /// 获取当前角色
        /// </summary>
        public static IEnumerable<string> GetCurrentRoles(this HttpContext context)
        {
            return from e in context.User.Claims
                   where e.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
                   select e.Value;
        }

        /// <summary>
        /// 获取当前角色
        /// </summary>
        public static IEnumerable<string> GetCurrentRoles(this ClaimsPrincipal user)
        {
            return from e in user.Claims
                   where e.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
                   select e.Value;
        }
    }
}
