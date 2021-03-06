using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class ProductRegistrationManager : IProductRegistrationService
    {
        IProductRegistrationDAL _productRegistrationDAL;

        public ProductRegistrationManager(IProductRegistrationDAL productRegistrationDAL)
        {
            _productRegistrationDAL = productRegistrationDAL;
        }



        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ProductRegistrationValidator))]
        [CacheRemoveAspect("IProductRegistrationService.Get")]
        public IResult Add(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Add(productRegistration);
            return new SuccessResult(Messages.Succes);
        }


        [SecuredOperation("admin")]
        public IResult Delete(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Delete(productRegistration);

            return new SuccessResult(Messages.Succes);

        }
        [SecuredOperation("admin")]
        [CacheAspect(duration:60)]
        public IDataResult<List<ProductRegistration>> GetAll()
        {
            Console.WriteLine(Messages.Listing);
            return new SuccessDataResult<List<ProductRegistration>>(_productRegistrationDAL.GetAll(), Messages.Succes);

        }
        [SecuredOperation("admin")]
        [PerformanceAspect(5)]
        public IDataResult<List<ProductDetailsDto>> GetProductDetails()
        {
            Thread.Sleep(5000);
            return new SuccessDataResult<List<ProductDetailsDto>>(_productRegistrationDAL.GetProductDetails(), Messages.Succes);
        }

        [SecuredOperation("admin")]
        [CacheAspect(duration:10)]
        public IDataResult<ProductRegistration> GetProductRegistrationById(int productRegistrationId)
        {
            return new SuccessDataResult<ProductRegistration>(_productRegistrationDAL.Get(x => x.NewProductId == productRegistrationId), Messages.Succes);
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ProductRegistrationValidator))]
        [CacheRemoveAspect("IProductRegistrationService.Get")]
        public IResult Update(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Update(productRegistration);

            return new SuccessResult(Messages.Succes);
        }



        [TransactionScopeAspect]
        public IResult AddTransactionalTest(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Update(productRegistration);
            _productRegistrationDAL.Add(productRegistration);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
