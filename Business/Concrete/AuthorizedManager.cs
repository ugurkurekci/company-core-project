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
    public class AuthorizedManager : IAuthorizedService
    {
        IAuthorizedDAL _authorizedDAL;

        public AuthorizedManager(IAuthorizedDAL authorizedDAL)
        {
            _authorizedDAL = authorizedDAL;
        }

        public IResult Add(Authorized authorized)
        {


            _authorizedDAL.Add(authorized);
            Console.WriteLine("\n" + " NAME: " + authorized.AuthorizedName + "\n" + " SURNAME: " + authorized.AuthorizedSurname + "\n" + " SALARY: " + authorized.AuthorizedSalary + "TL" + "\n" + " START: " + authorized.AuthorizedDateofStart + "\n" + " FİNİSH: " + authorized.AuthorizedDateofOut + "\n" + " Added to Database.......... ");
            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(Authorized authorized)
        {
            _authorizedDAL.Delete(authorized);
            Console.WriteLine("\n" + " IdentificationNumber: " + authorized.IdentificationNumber + " Deleted to Database......... ");
            return new SuccessResult(Messages.Succes);
        }

        public IDataResult<List<Authorized>> GetAll()
        {
            Console.WriteLine(" Listing..................... " + " \n ");
            return new SuccessDataResult<List<Authorized>>(_authorizedDAL.GetAll(), (Messages.Listing));

        }

        public IDataResult<Authorized> GetAuthorizedById(int authorizedId)
        {
            return new SuccessDataResult<Authorized>(_authorizedDAL.Get(x => x.IdentificationNumber == authorizedId));
        }

        public IResult Update(Authorized authorized)
        {
            Console.WriteLine("\n\n" + " NAME :" + authorized.AuthorizedName + "\n" + " SURNAME: " + authorized.AuthorizedSurname + "\n" + " SALARY: " + authorized.AuthorizedSalary + "TL" + "\n" + " START: " + authorized.AuthorizedDateofStart + "\n" + " FİNİSH: " + authorized.AuthorizedDateofOut + "\n" + " Updated to Database.......... ");
            _authorizedDAL.Update(authorized);
            return new SuccessResult(Messages.Succes);
        }
    }
}
