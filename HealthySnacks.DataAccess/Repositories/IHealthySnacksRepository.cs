using System.Collections.Generic;

namespace HealthySnacks.DataAccess.Repositories
{
    public interface IHealthySnacksRepository
    {

        //public void CreateHealthySnacks(HealthySnacks.DataAccess.Entities.HealthySnacks healthySnacks);

        //public HealthySnacks.DataAccess.Entities.HealthySnacks GetHealthySnacksById(int id);

        public List<HealthySnacks.DataAccess.Entities.HealthySnacks> GetHealthySnacks();

        //public void EditHealthySnacks(HealthySnacks.DataAccess.Entities.HealthySnacks healthySnacks);

        //public void DeleteHealthySnacksById(int id);
    }
}
