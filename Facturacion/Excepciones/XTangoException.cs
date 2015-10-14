using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Facturacion.Excepciones
{
    class XTangoException : Exception, ISerializable
    {
        public XTangoException(string message)
            : base(message)
        { }
    }
}
