using OnlinePrescription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrescription.Repository
{
    public class DatabaseRepository
    {
        protected DatabaseContext databaseContext = new DatabaseContext();
    }
}
