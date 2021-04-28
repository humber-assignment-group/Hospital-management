using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace hospital_management.Models
{
    public class ContextClass:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}