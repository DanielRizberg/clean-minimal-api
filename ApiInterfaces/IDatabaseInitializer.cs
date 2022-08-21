using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterfaces
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync(); 
    }
}
