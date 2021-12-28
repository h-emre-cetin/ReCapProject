using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IResultService
    {

        IResult Add(Result result); 
        IResult Delete(Result result); 
        IResult Update(Result result);
    }
}
