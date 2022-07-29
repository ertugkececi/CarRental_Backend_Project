﻿using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
        List<Color> GetAll();
        Color GetByColorId(int colorId);
    }
}
