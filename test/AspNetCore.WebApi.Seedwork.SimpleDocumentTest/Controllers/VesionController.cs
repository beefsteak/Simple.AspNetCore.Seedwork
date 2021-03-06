﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Simple.AspNetCore.Seedwork.Test.Controllers
{
    /// <summary>
    /// Test
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class VesionController : ControllerBase
    {
        [HttpGet("exceptiontest")]
        public IActionResult Exception()
        {
            throw new ArgumentException("have a bug");
        }

        // GET api/vesion
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/vesion/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/vesion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/vesion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/vesion/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}