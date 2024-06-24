﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "Hello int " + id;
        }

        [Route("{id:minlength(5):alpha}")]
        public string GetByIdString(string id)
        {
            return "Hello String " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Hello Regex " + id;
        }
    }
}
