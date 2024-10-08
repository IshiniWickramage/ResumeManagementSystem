﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeManagementSystem.Core.Context;
using ResumeManagementSystem.Core.Dtos.Company;
using ResumeManagementSystem.Core.Entities;

namespace ResumeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context=context;
            _mapper=mapper;
        }

        //--------------CRUD Operations---------------

        //CREATE 
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
                await _context.Companies.AddAsync(newCompany);
                await _context.SaveChangesAsync();

            return Ok("Company created successfully");
    }

        //READ
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CompanyGetDto>>> GetCompanies()
        {
            var companies = await _context.Companies.ToListAsync();
            var convertedCompanies = _mapper.Map<IEnumerable<CompanyGetDto>>(companies);

            return Ok(convertedCompanies);
        }
       
    }
}
