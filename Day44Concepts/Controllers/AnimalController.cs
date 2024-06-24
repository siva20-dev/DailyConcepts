using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Day44Concepts.Model;
using System.Linq;

namespace Day44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name ="Dog"},
                new AnimalModel() {Id = 2, Name ="Lion"}
            };
        }

        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return Accepted("~/api/Animal");
        }

        [Route("test2")]
        public IActionResult GetAnimalsTest2()
        {
            return AcceptedAtAction("GetAnimals");
        }

        [Route("test3")]
        public IActionResult GetAnimalsTest3()
        {
            return AcceptedAtRoute("All");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);
            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal);
        }

        [Route("test5")]
        public IActionResult GetAnimalsTest5()
        {
            return LocalRedirectPermanent("~/api/Animal");
        }
    }
}
