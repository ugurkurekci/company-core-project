using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdminService
    {
        IDataResult<List<Admin>> GetAll();
        IResult Add(Admin admin);
        IResult Delete(Admin admin);
        IResult Update(Admin admin);
        IDataResult<Admin> GetAdminById(int adminId);
        IDataResult<Admin> GetAdminLogin(string username, string password);






    }
}
