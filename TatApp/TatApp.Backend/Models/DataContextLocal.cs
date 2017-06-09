using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TatApp.Domain;

namespace TatApp.Backend.Models
{
    public class DataContextLocal:DataContext
    {
        public System.Data.Entity.DbSet<TatApp.Domain.DocumentType> DocumentTypes { get; set; }
    }
}