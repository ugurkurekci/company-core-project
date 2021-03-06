using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAdminService.Get")]
        public IResult Add(Admin admin)
        {

           IResult result = BusinessRules.Run(CheckIfAdminNameMailExist(admin.Name, admin.Mail));
            if (result!=null)
            {
                return result;
            }

            _adminDal.Add(admin);

            return new SuccessResult(Messages.AdminNameMailAlreadyExists);

            

        }
        [SecuredOperation("admin")]
        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);

            return new SuccessResult(Messages.Succes);
        }
        [SecuredOperation("admin")]
        [CacheAspect(duration: 60)]

        public IDataResult<List<Admin>> GetAll()
        {


            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll(), (Messages.Listing));
        }

        [SecuredOperation("admin")]
        [CacheAspect(duration: 10)]
        public IDataResult<Admin> GetAdminById(int adminId)
        {
            return new SuccessDataResult<Admin>(_adminDal.Get(x => x.AdminID == adminId));
        }

        [ValidationAspect(typeof(AdminValidator))]
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAdminService.Get")]
        public IResult Update(Admin admin)
        {

            _adminDal.Update(admin);
            return new SuccessResult(Messages.Succes);
        }

        [SecuredOperation("admin")]
        public IDataResult<Admin> GetAdminLogin(string username, string password)
        {

            return new SuccessDataResult<Admin>(_adminDal.Get(p => p.Name == username && p.Passw == password));

        }



        private IResult CheckIfAdminNameMailExist(string username, string mail)
        {
            var result = _adminDal.GetAll(p => p.Name == username & p.Mail == mail).Any();
            if (result)
            {
                return new ErrorResult(Messages.AdminNameMailAlreadyExists);
            }
            return new SuccessResult();
        }


    }

}
