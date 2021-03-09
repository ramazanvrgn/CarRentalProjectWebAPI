﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<User> GetById(int _userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
