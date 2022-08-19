using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities;
using WebApplicationTest.Helpers;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        private DataContext _context;
        private readonly IMapper _mapper;
        public PersonneController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpPost("AjouterPersone")]
        public IActionResult AjouterPersonne(Personne model)
        {
            int age = 0;
            age = DateTime.Now.AddYears(-model.DateDeNaissance.Year).Year;

            if (age >= 150)
            {
                return BadRequest(new { message = "vous ne pouvez pas ajouter une personne âgée de plus de 150 ans" });
            }


            _context.Personnes.Add(model);
            _context.SaveChanges();
            return Ok(new { message = "personne a été ajoutée" });
        }



        [HttpGet("GetAll")]
        public IActionResult GetAll()

        {

            int year = DateTime.Now.Year;
            return Ok(_context.Personnes.OrderBy(i => i.Nom).Select(i => new PersonneModel()
            {
                Nom = i.Nom,
                Prenom = i.Prenom,
                Age = year -i.DateDeNaissance.Year
            }).ToList());
        }
    }
}
