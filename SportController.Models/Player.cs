using System;

namespace SportController.Models
{
    public class Player : BaseEntity
    {

        //public int PlayerID { get; set; }
        public int ClubID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public double  Height { get; set; }
        public double Weight { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; }
        public string Picture { get; set; }
    }
}
