using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AboutMeManager : IAboutMeService
    {
        IAboutMeDAL _aboutMeDAL;

        public AboutMeManager(IAboutMeDAL aboutMeDAL)
        {
            _aboutMeDAL = aboutMeDAL;
        }

        [SecuredOperation("admin")]
        public IDataResult<List<AboutMe>> GetAll()
        {
            return new SuccessDataResult<List<AboutMe>>(_aboutMeDAL.GetAll());
        }
    }
}
