using HealthySnacks.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using HealthySnacks.Models;
using HealthySnacks.DataAccess.Entities;
using HealthySnacks.ControllersMappers;
using System.Collections.Generic;

namespace HealthySnacks.Controllers
{
    public class HealthySnacksController : Controller 
    {

        private HealthySnacksRepository healthySnacksRepository;
        private readonly Mapper _mapper;


        public HealthySnacksController()
        {
            healthySnacksRepository = new HealthySnacksRepository();
            _mapper = new Mapper();

        }

        public IActionResult Index() //same name of action Index, same name as a View Index in view folder
        {
            var healthySnacks = healthySnacksRepository.GetHealthySnacks();

            List<HealthySnacksModel> healthySnacksModels = new List<HealthySnacksModel>();

            foreach (var healthySnack in healthySnacks)
            {

                var healthySnackModel = _mapper.healthySnacksModel(healthySnack);
                healthySnacksModels.Add(healthySnackModel);
            }

            return View(healthySnacksModels);

        }
    }
}
