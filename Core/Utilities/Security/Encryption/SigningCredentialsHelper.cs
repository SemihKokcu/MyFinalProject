using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {//sisteme girmek için anahtar
        public static SigningCredentials CreateSigningCredentials(SecurityKey security)
        {
            //anahtar olarak security keyi al, şifreleme olarak HmacSha512signature
            return new SigningCredentials(security,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}

//aspnet için girişlerde ne kullanması gerektiğini söyledik, json web token için
