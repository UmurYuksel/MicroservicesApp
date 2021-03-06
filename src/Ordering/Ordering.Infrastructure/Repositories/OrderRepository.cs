using Microsoft.EntityFrameworkCore;
using Ordering.Core.Entities;
using Ordering.Core.Repositories;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        //NO DI NEEDED FOR THE dbContext. BECAUSE I Did it in the Repository classs which means I will be able to use it here too.
        public OrderRepository(OrderContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrderByUserName(string userName)
        {
            var orderList = await _dbContext.Orders.Where(o=>o.UserName== userName).ToListAsync();
            return orderList;
        }

    }
}
