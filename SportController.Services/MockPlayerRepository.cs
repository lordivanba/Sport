using System;
using System.Collections.Generic;
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
                new Player{PlayerID=4,ClubID=2,Name="Carles",LastName="Puyol",Birthday="13-04-1978",Height=1.78,Weight=90,Nationality="Spanish",Position="Defense"},
                new Player{PlayerID=4,ClubID=2,Name="Zinedine",LastName="Zidane",Birthday="23-6-1972",Height=1.85,Weight=90,Nationality="French",Position="Striker"},
            };

        }

        public IEnumerable<Player> GetAll()
        {
            return _players;
        }
    }
}
