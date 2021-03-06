using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthorizedManager : IAuthorizedService
    {
        IAuthorizedDAL _authorizedDAL;

        public AuthorizedManager(IAuthorizedDAL authorizedDAL)
        {
            _authorizedDAL = authorizedDAL;
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAuthorizedService.Get")]
        
        public IResult Add(Authorized authorized)
        {


            _authorizedDAL.Add(authorized);
            return new SuccessResult(Messages.Succes);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Authorized authorized)
        {
            _authorizedDAL.Delete(authorized);
            return new SuccessResult(Messages.Succes);
        }

        [SecuredOperation("admin")]
        [CacheAspect(duration: 60)]
        public IDataResult<List<Authorized>> GetAll()
        {
            return new SuccessDataResult<List<Authorized>>(_authorizedDAL.GetAll(), (Messages.Listing));

        }

        [SecuredOperation("admin")]
        [CacheAspect(duration: 10)]
        public IDataResult<Authorized> GetAuthorizedById(int authorizedId)
        {
            return new SuccessDataResult<Authorized>(_authorizedDAL.Get(x => x.IdentificationNumber == authorizedId));
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAuthorizedService.Get")]
        public IResult Update(Authorized authorized)
        {
            _authorizedDAL.Update(authorized);
            return new SuccessResult(Messages.Succes);
        }
    }
}
