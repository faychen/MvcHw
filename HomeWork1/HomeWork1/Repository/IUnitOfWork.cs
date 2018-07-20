using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HomeWork1.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; set; }

        void Commit();
    }
}