using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductRegistrationManager : IProductRegistrationService
    {
        IProductRegistrationDAL _productRegistrationDAL;

        public ProductRegistrationManager(IProductRegistrationDAL productRegistrationDAL)
        {
            _productRegistrationDAL = productRegistrationDAL;
        }

        [ValidationAspect(typeof(ProductRegistrationValidator))]
        public IResult Add(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Add(productRegistration);
            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Delete(productRegistration);

            return new SuccessResult(Messages.Succes);

        }

        public IDataResult<List<ProductRegistration>> GetAll()
        {
            Console.WriteLine(Messages.Listing);
            return new SuccessDataResult<List<ProductRegistration>>(_productRegistrationDAL.GetAll(), Messages.Succes);

        }

        public IDataResult<List<ProductDetailsDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailsDto>>(_productRegistrationDAL.GetProductDetails(), Messages.Succes);
        }

        public IDataResult<ProductRegistration> GetProductRegistrationById(int productRegistrationId)
        {
            return new SuccessDataResult<ProductRegistration>(_productRegistrationDAL.Get(x => x.NewProductId == productRegistrationId), Messages.Succes);
        }


        [ValidationAspect(typeof(ProductRegistrationValidator))]
        public IResult Update(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Update(productRegistration);

            return new SuccessResult(Messages.Succes);
        }
    }
}
