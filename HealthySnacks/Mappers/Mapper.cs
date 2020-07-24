namespace HealthySnacks.Controllers
{
    public class Mapper
    {
        public HealthySnacksModel healthySnacksModel(HealthySnacks healthySnacks)
        {
            HealthySnacksModel healthySnacksModel = new HealthySnacksModel();
            healthySnacksModel.Id = healthySnacks.Id;
            healthySnacksModel.Name = healthySnacks.Name;
            healthySnacksModel.Description = healthySnacks.Description;
            healthySnacksModel.Price = healthySnacks.Price;
            healthySnacksModel.ImageUrl = healthySnacks.ImageUrl;
            healthySnacksModel.CategoryId = healthySnacks.CategoryId;

            return healthySnacksModel;

        }

        public HealthySnacks MapToHealthySnacks(HealthySnacksModel healthySnacksModel)
        {
            HealthySnacks healthySnacks = new HealthySnacks();
            healthySnacks.Id = healthySnacksModel.Id;
            healthySnacks.Name = healthySnacksModel.Name;
            healthySnacks.Description = healthySnacksModel.Description;
            healthySnacks.Price = healthySnacksModel.Price;
            healthySnacks.ImageUrl = healthySnacksModel.ImageUrl;
            healthySnacks.CategoryId = healthySnacksModel.CategoryId;


        }
    }
}
