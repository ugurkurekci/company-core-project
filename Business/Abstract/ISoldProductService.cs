using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoldProductService
    {
        IDataResult<List<SoldProduct>> GetAll();
        IResult Add(SoldProduct soldProduct);
        IResult Delete(SoldProduct soldProduct);
        IResult Update(SoldProduct soldProduct);
        IDataResult<SoldProduct> GetSoldProductById(int soldProductId);
    }
}
