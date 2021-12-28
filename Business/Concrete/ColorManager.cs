using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length<1)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);

        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 13)

            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }

            _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(Messages.ColorListed);
        }

        public IDataResult<List<Color>> GetByColorName(string name)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorName == name));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
