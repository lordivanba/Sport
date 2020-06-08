using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportController.Models;
using SportController.Services;

namespace SportUI.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryPlayer repository;
        public IEnumerable<Player> Players { get; set; }
        public IndexModel(IRepositoryPlayer repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            Players = repository.GetAll();
        }
    }
}