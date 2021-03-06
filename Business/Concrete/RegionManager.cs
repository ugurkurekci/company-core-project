using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
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
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IRegionService.Get")]
        
        public IResult Add(Region region)
        {
            _regionDAL.Add(region);           
            return new SuccessResult(Messages.Succes);
        }
        [SecuredOperation("admin")]
        public IResult Delete(Region region)
        {
            _regionDAL.Delete(region);
           
            return new SuccessResult(Messages.Succes);

        }
        [SecuredOperation("admin")]
        [CacheAspect(duration: 60)]
        public IDataResult<List<Region>> GetAll()
        {
           
            return new SuccessDataResult<List<Region>>( _regionDAL.GetAll(),Messages.Succes);

        }
        [SecuredOperation("admin")]
        [CacheAspect(duration: 10)]
        public IDataResult<Region> GetById(int id)
        {
            return new SuccessDataResult<Region> (_regionDAL.Get(x => x.RegionId == id),Messages.Succes);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IRegionService.Get")]
        public IResult Update(Region region)
        {
            _regionDAL.Update(region);
            
            return new SuccessResult(Messages.Succes);
        }
    }
}
