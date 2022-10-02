using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        // IResult türünden istediğin kadar IResult verebilirsin
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; // başarısız ise başarısız olduğu yeri döndürücek
                }
            }

            return null;
        }
    }
}
