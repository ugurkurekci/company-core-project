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
    public class RegionManager : IRegionService
    {
        IRegionDAL _regionDAL;

        public RegionManager(IRegionDAL regionDAL)
        {
            _regionDAL = regionDAL;
        }

        public IResult Add(Region region)
        {
            _regionDAL.Add(region);
            Console.WriteLine("\n" + " Description: " + region.RegionDescription);
            return new SuccessResult(Messages.Succes);
        }

        public IResult Delete(Region region)
        {
            _regionDAL.Delete(region);
            Console.WriteLine("\n" + "RegionID: " + region.RegionId);
            return new SuccessResult(Messages.Succes);

        }

        public IDataResult<List<Region>> GetAll()
        {
            Console.WriteLine(Messages.Listing);
            return new SuccessDataResult<List<Region>>( _regionDAL.GetAll(),Messages.Succes);

        }

        public IDataResult<Region> GetById(int id)
        {
            return new SuccessDataResult<Region> (_regionDAL.Get(x => x.RegionId == id),Messages.Succes);
        }

        public IResult Update(Region region)
        {
            _regionDAL.Update(region);
            Console.WriteLine("\n" + " RegionID: " + region.RegionId + " Description: " + region.RegionDescription);
            return new SuccessResult(Messages.Succes);
        }
    }
}
