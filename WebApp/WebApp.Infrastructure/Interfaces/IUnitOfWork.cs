using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// goi phuong thuc save trong db context
        /// </summary>
        void Commit();

    }
}
