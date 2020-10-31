using System;
using System.Collections.Generic;
using System.Text;

namespace EWebApp.BLL.Exceptions
{
    public class ItemNotFoundEsception : Exception
    {
        public ItemNotFoundEsception(string message) : base(message)
        {
        }
    }
}
