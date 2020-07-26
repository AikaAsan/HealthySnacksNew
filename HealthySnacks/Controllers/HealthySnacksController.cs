using HealthySnacks.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using HealthySnacks.Models;
using HealthySnacks.DataAccess.Entities;


namespace HealthySnacks.Controllers
{
    public class HealthySnacksController : Controller 
    {

        private HealthySnacksRepository healthySnacksRepository;
        private readonly Mapper _mapper;


        public HealthySnacksController()
        {
            healthySnacksRepository = new HealthySnacksRepository();

        }

        public IActionResult Index() //same name of action Index, same name as a View Index in view folder
        {
            var healthySnacks = healthySnacksRepository.GetHealthySnacks();

            return View();
        }
    }
}
