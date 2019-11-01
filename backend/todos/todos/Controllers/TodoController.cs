﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace todos.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private static List<string> all = new List<string>()
        {
            "Remodel Bathroom",
            "Finish my laser app",
            "Do things with kids"
        };

        // GET api/todos
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return all;
        }

        // GET api/todos/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "todos";
        }

        // POST api/todoss
        [HttpPost]
        public ActionResult<IEnumerable<string>> Post([FromBody] string todos)
        {
            all.Add(todos);
            return all;
        }

        // PUT api/todoss/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string todos)
        {
        }

        // DELETE api/todoss/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
