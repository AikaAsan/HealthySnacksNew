using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthySnacks.DataAccess.Repositories
{
    public class HealthySnacksRepository : IHealthySnacksRepository
    {
        public HealthySnacksRepository()
        {
        }

        public List<HealthySnacks.DataAccess.Entities.HealthySnacks> GetHealthySnacks()
        {
            using (var context = new DatabaseContext())
            {
                return context.HealthySnacks.ToList();
            }
        }
    }
}
