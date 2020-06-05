using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dockertraining_compose_Manuel_Morales
{
    public class Person
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }
    }
	
	public class PersonContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public PersonContext(DbContextOptions options) : base(options) { }
    }
}
