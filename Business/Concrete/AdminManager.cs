using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDal;

        public AdminManager(IAdminDAL adminDal)
        {
            _adminDal = adminDal;
        }


        [ValidationAspect(typeof(AdminValidator))]
        public IResult Add(Admin admin)
        {

            _adminDal.Add(admin);

            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);

            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<List<Admin>> GetAll()
        {


            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll(), (Messages.Listing));
        }

        public IDataResult<Admin> GetAdminById(int adminId)
        {
            return new SuccessDataResult<Admin>(_adminDal.Get(x => x.AdminID == adminId));
        }

        [ValidationAspect(typeof(AdminValidator))]
        public IResult Update(Admin admin)
        {

            _adminDal.Update(admin);
            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<Admin> GetAdminLogin(string username, string password)
        {

            return new SuccessDataResult<Admin>(_adminDal.GetTwo(x => x.Name == username || x.Passw == password));
        }
    }
}
