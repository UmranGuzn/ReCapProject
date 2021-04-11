using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Utilities.Results;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
        public IResult AddUserAsCustomer()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                    var result = context.Users.OrderByDescending(u => u.UserId).FirstOrDefault();
                if (result.UserId != -1)
                {
                    Customer customer = new Customer() { UserId = result.UserId, FindexNumber = 1900, CustomerName = result.FirstName + " " + result.LastName };
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    return new SuccessResult();
                }
                return new ErrorResult();
            }
           
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
