using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
       List<OperationClaim> GetClaims(User user);

        IDataResult<List<User>> GetAll();

        IDataResult<User> GeById(int id);

        IResult Update(User user);

        IResult Add(User user);

        IResult Delete(User user);
        
        IDataResult<User> GetByMail(string email);

        IResult AddUserAsCustomer();

        IResult EditProfile(UserForUpdateDto user);
    }
}
