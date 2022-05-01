using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Entidades
{
    public abstract class BaseDTO : IDisposable
    {
        public String id { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
