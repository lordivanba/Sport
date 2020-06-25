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
    public class DetailsModel : PageModel
    {
        private readonly IRepositoryPlayer repository;
        public Player Player { get; private set; }

        public DetailsModel(IRepositoryPlayer repository)
        {
            this.repository = repository;
        }
        public void OnGet(int id)
        {
            Player = repository.Get(id);
        }
    }
}