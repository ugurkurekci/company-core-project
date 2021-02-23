using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerRegistrationManager : ICustomerRegistrationService
    {
        ICustomerRegistrationDAL _customerRegistrationDAL;

        public CustomerRegistrationManager(ICustomerRegistrationDAL customerRegistrationDAL)
        {
            _customerRegistrationDAL = customerRegistrationDAL;
        }

        [ValidationAspect(typeof(CustomerRegistrationValidator))]
        public IResult Add(CustomerRegistration customerRegistration)
        {
            _customerRegistrationDAL.Add(customerRegistration);
            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(CustomerRegistration customerRegistration)
        {
            _customerRegistrationDAL.Delete(customerRegistration);

            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<List<CustomerRegistration>> GetAll()
        {
            Console.WriteLine(Messages.Listing);
            return new SuccessDataResult<List<CustomerRegistration>>(_customerRegistrationDAL.GetAll(), (Messages.Listing));

        }

        public IDataResult<CustomerRegistration> GetCustomerRegistrationById(int customerRegistrationId)
        {
            return new SuccessDataResult<CustomerRegistration>(_customerRegistrationDAL.Get(x => x.NewCustomerId == customerRegistrationId));
        }

        [ValidationAspect(typeof(CustomerRegistrationValidator))]
        public IResult Update(CustomerRegistration customerRegistration)
        {

            _customerRegistrationDAL.Update(customerRegistration);
            return new SuccessResult(Messages.Succes);
        }
    }
}
