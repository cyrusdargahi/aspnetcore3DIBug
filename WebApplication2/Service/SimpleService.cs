using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Service
{
    public class SimpleService
    {
        public SimpleService(decimal value = 0.01m)
        {
            Value = value;
        }

        public decimal Value { get; }
    }
}
