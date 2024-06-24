using Day25Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties]
    [BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        //[BindProperty]
        //[BindProperty(SupportsGet = true)]
        public CountryModel Country { get; set; }
        //[BindProperty]
        //public string Name { get; set; }
        ////[BindProperty]
        //public int Population { get; set; }
        ////[BindProperty]
        //public int Area { get; set; }


        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name = {this.Name},Population = {this.Population},Area = {this.Area}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryModelExample()
        //{
        //    return Ok($"Name = {this.Country.Name},Population = {this.Country.Population},Area = {this.Country.Area}");
        //}

        //[HttpGet("")]
        //public IActionResult AddCountryModelExample2()
        //{
        //    return Ok($"Name = {this.Country.Name},Population = {this.Country.Population},Area = {this.Country.Area}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryExample4()
        //{
        //    return Ok($"Name = {this.Name},Population = {this.Population},Area = {this.Area}");
        //}

        //[HttpGet("")]
        //public IActionResult AddCountryModelExample4()
        //{
        //    return Ok($"Name = {this.Country.Name},Population = {this.Country.Population},Area = {this.Country.Area}");
        //}

        //[HttpGet("")]
        //public IActionResult AddCountryDefaultDataBindingExample1(string name, int area)
        //{
        //    return Ok($"Name = {name}");
        //}

        //[HttpGet("{name}/{area}")]
        //public IActionResult AddCountryDefaultDataBindingExample2(string name, int area)
        //{
        //    return Ok($"Name = {name}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryDefaultDataBindingExample3(CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpGet("{name}")]
        //public IActionResult AddCountryFromQueryExample([FromQuery] string name)
        //{
        //    return Ok($"Name = {name}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryFromQueryExample2([FromQuery] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryFromQueryExample3([FromQuery]int id, [FromQuery] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("{name}")]
        //public IActionResult AddCountryFromRouteExample([FromRoute] string name)
        //{
        //    return Ok($"Name = {name}");
        //}

        //[HttpPost("{Name}/{Population}/{Area}")]
        //public IActionResult AddCountryFromRouteExample2([FromRoute] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("{Name}/{Population}/{Area}")]
        //public IActionResult AddCountryFromAndRouteQueryExample2([FromRoute] CountryModel country, [FromQuery] int id)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("{id}")]
        //public IActionResult AddCountryFromBodyExample([FromBody] int id)
        //{
        //    return Ok($"Id = {id}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountryFromBodyExample2([FromBody] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPut("{id}")]
        //public IActionResult AddCountryFromBodyExample3([FromRoute] int id, [FromBody] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("{id}")]
        //public IActionResult AddCountryFromFormExample([FromRoute] int id, [FromForm] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}

        //[HttpPost("{id}")]
        //public IActionResult AddCountryFromHeaderExample([FromRoute] int id, [FromHeader] string developer)
        //{
        //    return Ok($"Name = {developer}");
        //}

        //[HttpPost("{id}")]
        //public IActionResult AddCountryFromHeaderExample2([FromRoute] int id, [FromHeader] string developer,[FromHeader] string technology)
        //{
        //    return Ok($"Name = {developer}");
        //}
    }
}
