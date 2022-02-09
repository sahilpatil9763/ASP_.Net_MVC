using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFeameworkCore;

namespace Bike_Selling_Management_System.App_DB_Context
{
    public class Bike_Selling_DBContext:DbContext
    {
        public Bike_Selling_DBContext(DbContextOptions<Bike_Selling_DBContext> options)
        {

        }
    }
}
