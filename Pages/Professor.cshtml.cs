using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab_11_Professor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_11_Professor.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        public ProfessorModel(ProfessorDbContext context)
        {
            _context = context;
        }
        public List<Professor> Professors {get; set;}
        public SelectList ProfessorDropDown {get; set;}

        public void OnGet()
        {
            Professors = _context.Professor.ToList();

            ProfessorDropDown = new SelectList(Professors, "ID", "FirstName", "LastName");
        }

        public void ButtonClick()
        {

        }
    }
}
