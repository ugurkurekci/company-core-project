using Business.Abstract;
using Business.Constants;
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

        public IResult Add(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Add(productRegistration);
            Console.WriteLine("\n" + " PRODUCT NAME: " + productRegistration.NewProductName + "\n"
                + " PRICE: " + productRegistration.NewProductPrice + "\n" + " QUANTITY: "
                + productRegistration.NewProductQuantity + "\n" + " IMAGE: " + productRegistration.NewProductImage + "\n"
                + " Added to Database....... ");

            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(ProductRegistration productRegistration)
        {
            _productRegistrationDAL.Delete(productRegistration);
            Console.WriteLine("\n\n" + " PRODUCT ID: " + productRegistration.NewProductId + "\n" + productRegistration.NewProductName
                + "\n" + " Deleted to Database.........");
            return new SuccessResult(Messages.Succes);

        }

        public IDataResult<List<ProductRegistration>> GetAll()
        {
            Console.WriteLine(Messages.Listing + "\n");
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

        public IResult Update(ProductRegistration productRegistration)
        {
            Console.WriteLine("\n" + " PRODUCT NAME: " + productRegistration.NewProductName
                + "\n" + " PRICE: " + productRegistration.NewProductPrice + "\n" + " QUANTITY: "
                + productRegistration.NewProductQuantity + "\n" + " IMAGE: " + productRegistration.NewProductImage + "\n" + " Updated to Database....... ");
            return new SuccessResult(Messages.Succes);
        }
    }
}
