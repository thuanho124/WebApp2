using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagementWithAuthen.Data;
using LibraryManagementWithAuthen.Models;

namespace LibraryManagementWithAuthen.Controllers
{
    public class StudentsController : Controller
    {
        private readonly LibDbContext _context;

        public StudentsController(LibDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {

            var student = await _context.Students
                .Include(r => r.RentedBooks)
                    .ThenInclude(b => b.Book)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.StudentID == id);

            return View(student);
        }
    }
}
