﻿using System;
using System.Collections.Generic;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetByBrandId(int brandId);
    }
}

