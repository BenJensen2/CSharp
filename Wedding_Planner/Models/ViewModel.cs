using System.Collections.Generic;

namespace Wedding_Planner.Models
{
    public class ViewModel
    {
// Used for dashboard
        public User loggedUser { get; set; }
        public List<Wedding> allWeddings { get; set; }
        public User User { get; set; }
        public Wedding Wedding { get; set; }
    }
}