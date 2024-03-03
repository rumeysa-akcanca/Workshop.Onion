﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.Services;
using OnionArcExample.Domain.Entities;

namespace OnionArcExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        readonly IEmailService _emailService;
        public ProductController(IProductRepository productRepository,IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> allProduct =await _productRepository.GetAsync();
            return Ok(allProduct);
        }
        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            bool result = _emailService.Send("rum@canca.com", "şişeler şişeler..");
            return Ok(result);
        }

    }
}
