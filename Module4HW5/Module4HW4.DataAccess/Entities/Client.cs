using System;
using System.Collections.Generic;
using System.Text;

namespace Module4HW4.DataAccess.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
