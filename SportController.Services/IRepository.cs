using System;
using System.Collections.Generic;
using System.Text;
using SportController.Models;


namespace SportController.Services
{
    public interface IRepositoryPlayer
    {
        public IEnumerable<Player> GetAll();
        public Player Get(int);

    }
    public interface IRepositoryClub
    {
        public IEnumerable<Club> GetAll();
        public Club Get(int);

    }
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);
    }

}
