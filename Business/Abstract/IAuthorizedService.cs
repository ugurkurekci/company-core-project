using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorizedService
    {
        IDataResult<List<Authorized>> GetAll();
        IResult Add(Authorized authorized);
        IResult Delete(Authorized authorized);
        IResult Update(Authorized authorized);
        IDataResult<Authorized> GetAuthorizedById(int authorizedId);
    }
}
