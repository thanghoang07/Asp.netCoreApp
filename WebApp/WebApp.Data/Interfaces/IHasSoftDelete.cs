using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
       bool IsDelete { get; set; }
    }
}
