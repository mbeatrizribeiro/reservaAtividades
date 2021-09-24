using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaAtividades.Data
{
   public class DbInitializer
    {
        public static void Initialize(ReservasContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
