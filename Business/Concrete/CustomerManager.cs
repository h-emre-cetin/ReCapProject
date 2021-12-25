using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add()
        {
            _customerDal.Add(customer);

            return new SuccessResult();
        }

        public IResult Delete()
        {
            throw new NotImplementedException();
        }

        public IResult Update()
        {
            throw new NotImplementedException();
        }
    }
}
