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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add()
        {
            throw new NotImplementedException();
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
