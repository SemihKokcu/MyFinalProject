using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //message boş olabilir, successi set etme işini overload olmuş ikinci constructor yapacak
        public Result(bool success, string message):this(success)//=> bu classın tek paramtreli constructorunu da çalıştır
        {
           Message = message;
        }
        public Result(bool success)
        {
            Success = success;
           
        }

        //setter eklemiyoruz çünkü harici bir yerde farklı bir amaçla çağrılmasını istemiyoruz
        // getter readonly dir constructor dan set edilebilir
        public bool Success  {get;} 
        public string Message { get; }
    }
}
