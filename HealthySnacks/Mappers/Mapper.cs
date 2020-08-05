using HealthySnacks.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using HealthySnacks.Models;
using HealthySnacks.DataAccess.Entities;

namespace HealthySnacks.ControllersMappers

{
    public class Mapper
    {
        public HealthySnacksModel healthySnacksModel(DataAccess.Entities.HealthySnacks healthySnacks)
    {
        var healthySnacksModel = new HealthySnacksModel();
        healthySnacksModel.Id = healthySnacks.Id;
        healthySnacksModel.Name = healthySnacks.Name;
        healthySnacksModel.Description = healthySnacks.Description;
        healthySnacksModel.Price = healthySnacks.Price;
        healthySnacksModel.ImageUrl = healthySnacks.ImageUrl;
        healthySnacksModel.CategoryId = healthySnacks.CategoryId;
        healthySnacksModel.Ingredients = healthySnacks.Ingredients;

        return healthySnacksModel;

    }

     public DataAccess.Entities.HealthySnacks MapToHealthySnacks(HealthySnacksModel healthySnacksModel)
    {
            var healthySnacks = new DataAccess.Entities.HealthySnacks
            {
                Id = healthySnacksModel.Id,
                Name = healthySnacksModel.Name,
                Description = healthySnacksModel.Description,
                Price = healthySnacksModel.Price,
                ImageUrl = healthySnacksModel.ImageUrl,
                CategoryId = healthySnacksModel.CategoryId,
                Ingredients = healthySnacksModel.Ingredients
        };

            return healthySnacks;
    }
    }
}
