using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetByCarId(int id);

        IDataResult<List<Rental>> GetByCustomerId(int id);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();

    }
}
