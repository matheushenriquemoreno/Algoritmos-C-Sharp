using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_capitulo_09.Entities.Enum
{
   enum OrderStatus : int
    {
        Pendig_Payment = 0,
        Processing  = 1,
        Shipped = 2,
        Delivered = 3
    }
}
