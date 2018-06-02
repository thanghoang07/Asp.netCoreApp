using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True neu domain entity has an identity 
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
