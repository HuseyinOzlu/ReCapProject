using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class UserManager : IUserService
    {
        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }

        public IResult Add(Users user)
        {
            _user.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(Users user)
        {
            _user.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_user.GetAll());
        }

        public IResult Update(Users user)
        {
            _user.Update(user);
            return new SuccessResult();
        }
    }
}
