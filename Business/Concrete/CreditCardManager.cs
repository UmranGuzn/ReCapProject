﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.AddedCreditCard);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.DeletedCreditCard);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CreditCard>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CustomerId == userId));
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.UpdatedCreditCard);
        }
    }
}
