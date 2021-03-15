using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            IResult result = BusinessRules.Run(ColorNameOfAlreadyExist(color.ColorName));
            if (result != null)
            {
                return result;
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
            //İş kodları
             

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.AllListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {


            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);

            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult ColorNameOfAlreadyExist(string colorName)
        {
            var result = _colorDal.GetAll(p => p.ColorName == colorName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ColorNameAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
