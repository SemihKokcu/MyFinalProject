using Business.Constans;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.IoC;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.BusinessAspects.Autofac
{//yetki kontrolü, JWT için
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; // httpcontext istekler için her bir kişiye oluşturuklur
        //roller virgülle ayrılarak geliyor
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(','); // metni split ediyorum
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }
        //kullanının rollerini bul gez claimlerinin içinde ilgili rol varsa method çalışsın yoksa hata
        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();//kullanıcı rollerini al
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))//gez ve bak
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
