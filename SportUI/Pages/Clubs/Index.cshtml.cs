using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportController.Models;
using SportController.Services;

namespace SportUI.Pages.Clubs
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryClub repository;
        public IEnumerable<Club> Clubs { get; set; }
        public IndexModel(IRepositoryClub repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            Clubs = repository.GetAll();
        }
    }
}