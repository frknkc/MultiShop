using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries
{
    public class GetOrderDetailQueryById
    {
        public int Id { get; set; }

        public GetOrderDetailQueryById(int id) {
            Id = id;
        }
    }
}
