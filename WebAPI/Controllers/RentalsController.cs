﻿using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalsService _rentalsService;

        public RentalsController(IRentalsService rentalsService)
        {
            _rentalsService = rentalsService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalsService.GetAll();
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rentals rentals)
        {
            var result = _rentalsService.Add(rentals);
            if(result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rentals rentals)
        {
            var result = _rentalsService.Remove(rentals);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rentals rentals)
        {
            var result = _rentalsService.Update(rentals);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }
    }
}
