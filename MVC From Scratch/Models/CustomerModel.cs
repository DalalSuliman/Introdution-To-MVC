using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public CustomerModel (int id , string name , int age , string address)
        {
            ID = id;
            Name = name;
            Age = age;
            Address = address;
        }
    }
}