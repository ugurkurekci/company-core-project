using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductRegistrationService
    {
        IDataResult<List<ProductRegistration>> GetAll();
        IResult Add(ProductRegistration productRegistration);
        IResult Delete(ProductRegistration productRegistration);
        IResult Update(ProductRegistration productRegistration);
        IDataResult<ProductRegistration> GetProductRegistrationById(int productRegistrationId);
        IDataResult<List<ProductDetailsDto>> GetProductDetails();
    }
}
