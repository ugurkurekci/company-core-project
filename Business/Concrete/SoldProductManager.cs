using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
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
    public class SoldProductManager : ISoldProductService
    {
        ISoldProductDAL _soldProductDAL;

        public SoldProductManager(ISoldProductDAL soldProductDAL)
        {
            _soldProductDAL = soldProductDAL;
        }

        [ValidationAspect(typeof(SoldProductValidator))]
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ISoldProductService.Get")]
        public IResult Add(SoldProduct soldProduct)
        {
            _soldProductDAL.Add(soldProduct);

            return new SuccessResult(Messages.Succes);
        }

        [SecuredOperation("admin")]
        public IResult Delete(SoldProduct soldProduct)
        {
            _soldProductDAL.Delete(soldProduct);
            return new SuccessResult(Messages.Succes);
        }

        [SecuredOperation("admin")]
        [CacheAspect(duration: 60)]
        public IDataResult<List<SoldProduct>> GetAll()
        {

            return new SuccessDataResult<List<SoldProduct>>(_soldProductDAL.GetAll());
        }


        [SecuredOperation("admin")]
        [CacheAspect(duration: 10)]
        public IDataResult<SoldProduct> GetSoldProductById(int soldProductId)
        {
            return new SuccessDataResult<SoldProduct>(_soldProductDAL.Get(x => x.BuyerId == soldProductId));
        }

        [ValidationAspect(typeof(SoldProductValidator))]
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ISoldProductService.Get")]
        public IResult Update(SoldProduct soldProduct)
        {
            _soldProductDAL.Update(soldProduct);

            return new SuccessResult(Messages.Succes);

        }
    }
}
