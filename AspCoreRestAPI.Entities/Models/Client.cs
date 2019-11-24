using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreRestAPI.Entities.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Descripion { get; set; }
        public bool IsCompany { get; set; }
        public int ParentID { get; set; }
    }
}
