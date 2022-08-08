﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries.OrderQueries.GetAllOrders
{
    public class GetAllOrderQueryResponse
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}