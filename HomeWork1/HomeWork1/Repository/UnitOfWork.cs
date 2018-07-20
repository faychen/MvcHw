using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HomeWork1.Models;

namespace HomeWork1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get ; set; }

        public UnitOfWork()
        {
            Context = new AccountBookModel();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}