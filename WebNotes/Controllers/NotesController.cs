using Microsoft.AspNetCore.Mvc;
using WebNotesData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        
        readonly WebNotesContext webNotesContext;
        public NotesController(WebNotesContext webNotesContext)
        {
            this.webNotesContext = webNotesContext;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = webNotesContext.categories.ToList();
            return Ok(categories);
        }
        [HttpPost]
        public IActionResult CreateCategories() 
        {
            var category = new categories()
            {
                name = "caaat"
            };
            webNotesContext.Add(category);
            webNotesContext.SaveChanges();

            return Ok("OK");
        }
    }
}
