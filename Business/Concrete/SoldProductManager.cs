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

            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(SoldProduct soldProduct)
        {
            _soldProductDAL.Delete(soldProduct);
            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<List<SoldProduct>> GetAll()
        {

            return new SuccessDataResult<List<SoldProduct>>(_soldProductDAL.GetAll());
        }

        public IDataResult<SoldProduct> GetSoldProductById(int soldProductId)
        {
            return new SuccessDataResult<SoldProduct>(_soldProductDAL.Get(x => x.BuyerId == soldProductId));
        }

        public IResult Update(SoldProduct soldProduct)
        {
            _soldProductDAL.Update(soldProduct);

            return new SuccessResult(Messages.Succes);

        }
    }
}
