using System.Collections.Generic;

namespace Wedding_Planner.Models
{
    public class Dashboard
    {
        public User loggedUser { get; set; }
        public List<Wedding> allWeddings { get; set; }
    }
}