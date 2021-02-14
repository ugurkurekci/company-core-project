using Business.Abstract;
using Business.Constants;
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

        public IResult Add(SoldProduct soldProduct)
        {
            _soldProductDAL.Add(soldProduct);
            Console.WriteLine("\n" + " BUYER PRODUCT: " + soldProduct.BuyerProject + "\n"
                + " BUYER NAME: " + soldProduct.BuyerName + "\n" + " BUYER SURNAME: "
                + soldProduct.BuyerSurname + "\n" + " BUYER PRICE: " + soldProduct.BuyerPrice + "\n"
                + " BUYER QUANTITY: " + soldProduct.BuyerQuantity + "\n" + " BUYER IMAGE: " + soldProduct.BuyerImage + "\n"
                + " Added to Database....... ");
            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(SoldProduct soldProduct)
        {
            _soldProductDAL.Delete(soldProduct);
            Console.WriteLine("\n\n" + " BUYER ID: " + soldProduct.BuyerId + "\n" + " BUYER PRODUCT:" + soldProduct.BuyerProject + "\n" + " Deleted to Database.........");
            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<List<SoldProduct>> GetAll()
        {
            Console.WriteLine(" Listing..................... " + "\n");
            return new SuccessDataResult<List<SoldProduct>>(_soldProductDAL.GetAll(), Messages.Succes);
        }

        public IDataResult<SoldProduct> GetSoldProductById(int soldProductId)
        {
            return new SuccessDataResult<SoldProduct>(_soldProductDAL.Get(x => x.BuyerId == soldProductId));
        }

        public IResult Update(SoldProduct soldProduct)
        {
            _soldProductDAL.Update(soldProduct);
            Console.WriteLine("\n" + " BUYER PRODUCT: " + soldProduct.BuyerProject
                + "\n" + " BUYER NAME: " + soldProduct.BuyerName + "\n" + " BUYER SURNAME: "
                + soldProduct.BuyerSurname + "\n" + " BUYER PRICE: " + soldProduct.BuyerPrice + "\n" + " BUYER QUANTITY: " + soldProduct.BuyerQuantity
                + "\n" + " BUYER IMAGE: " + soldProduct.BuyerImage + "\n" + " Updated to Database....... ");
            return new SuccessResult(Messages.Succes);

        }
    }
}
