using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Enumeração_Composição.Entities
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
