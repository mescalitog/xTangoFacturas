using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Excepciones
{
    class XTangoException : Exception
    {
        public XTangoException(string message)
            : base(message)
        { }
    }
}
