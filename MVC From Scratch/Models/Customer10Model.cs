using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Customer10Model
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Enter Your Name")]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }
        public Customer10Model()
        {
        }
        public Customer10Model(int id, string name, int age, string address)
        {
            ID = id;
            Name = name;
            Age = age;
            Address = address;
        }
    }
}