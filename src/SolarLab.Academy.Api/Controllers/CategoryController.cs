﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolarLab.Academy.AppServices.Categories.Services;
using SolarLab.Academy.Contracts.Categories;
using System.Net;

namespace SolarLab.Academy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryCreateModel model, CancellationToken cancellationToken)
        {
            var result = await _categoryService.CreateAsync(model, cancellationToken);
            return StatusCode((int)HttpStatusCode.Created, result);
        }
    }
}
