﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Operations
{
    class MulFactory : IFactory
    {
    public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
