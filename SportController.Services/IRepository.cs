using System;
using System.Collections.Generic;
using System.Text;
using SportController.Models;

namespace SportController.Services
{
    public interface IRepositoryPlayer
    {
        public IEnumerable<Player> GetAll();

    }
}
