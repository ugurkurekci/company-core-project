using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerRegistrationService
    {
        IDataResult<List<CustomerRegistration>> GetAll();
        IResult Add(CustomerRegistration  customerRegistration);
        IResult Delete(CustomerRegistration customerRegistration);
        IResult Update(CustomerRegistration customerRegistration);
       IDataResult<CustomerRegistration> GetCustomerRegistrationById(int customerRegistrationId);

    }
}
