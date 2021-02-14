using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRegionService
    {
        IDataResult<List<Region>> GetAll();
        IDataResult<Region> GetById(int id);
        IResult Add(Region region);
        IResult Delete(Region region);
        IResult Update(Region region);
    }
}
