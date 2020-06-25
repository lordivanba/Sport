using System;
using System.Collections.Generic;
using System.Linq;
using SportController.Models;


namespace SportController.Services
{
    public class MockPlayerRepository : IRepositoryPlayer
    {

        private List<Player> _players;
        public MockPlayerRepository()
        {
            _players = new List<Player>()
            {
                new Player{PlayerID=1,ClubID=1,Name="Javier",LastName="Hernandez",Birthday="1-07-1989",Height=1.75,Weight=85,Nationality="Mexican",Position="Striker"},
                new Player{PlayerID=2,ClubID=1,Name="Guillermo",LastName="Ochoa",Birthday="22-12-1993",Height=1.83,Weight=110,Nationality="Mexican",Position="GoalKeeper"},
                new Player{PlayerID=3,ClubID=2,Name="Rafael",LastName="Marquez",Birthday="13-02-1970",Height=1.85,Weight=90,Nationality="Mexican",Position="Defense"},
                new Player{PlayerID=4,ClubID=2,Name="Iker",LastName="Casillas",Birthday="13-02-1981",Height=1.82,Weight=90,Nationality="Spanish",Position="GoalKeeper"},
                new Player{PlayerID=5,ClubID=2,Name="Carles",LastName="Puyol",Birthday="13-04-1978",Height=1.78,Weight=90,Nationality="Spanish",Position="Defense"},
                new Player{PlayerID=6,ClubID=2,Name="Zinedine",LastName="Zidane",Birthday="23-6-1972",Height=1.85,Weight=90,Nationality="French",Position="Striker"},
            };

        }

        public IEnumerable<Player> GetAll()
        {
            return _players;
        }
        public Player Get(int id)
        {
            return _players.FirstOrDefault(x => x.PlayerID == id);
        }
    }
    public class MockClubRepository : IRepositoryClub
    {

        private List<Club> _clubs;
        public MockClubRepository()
        {
            _clubs = new List<Club>()
            {
               new Club{ClubID=1,Name="Malix FC",City="Calkiní",Country="Mexico"},
               new Club{ClubID=2,Name="Cruz Azul",City="Mexico City",Country="Mexico"},
               new Club{ClubID=3,Name="River Plate FC",City="Buenos Aires",Country="Argentina"}
            };

        }

        public IEnumerable<Club> GetAll()
        {
            return _clubs;
        }
        public Club Get(int id)
        {
            return _clubs.FirstOrDefault(x => x.ClubID == id);
        }
    }
}
