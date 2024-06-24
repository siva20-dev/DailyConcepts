using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Day25Concepts.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
        [Route("~/getall")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from get all Authors";
        }

        //[Route("books/{Id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "Hello Author Adress" + id + " " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId,string name, int rating, int price)
        {
            return "Hello from Search";
        }
    }
}
