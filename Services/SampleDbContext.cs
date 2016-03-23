using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using UsingJSONTextFileAsADataStore.Models;

namespace UsingJSONTextFileAsADataStore.Services
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class SampleDbContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Person> People { get; set; }
    }
}
