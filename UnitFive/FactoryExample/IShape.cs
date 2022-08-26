﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public interface IShape
    {
        public double CalculateArea();
        public void Draw();
    }
}
