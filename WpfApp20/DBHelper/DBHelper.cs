using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp20.DataBase;

namespace WpfApp20.DBHelper
{
   public static class DBHelper
    {
        private static CompaneEntities Context = new CompaneEntities();

        public static CompaneEntities GetContext()
        {
            return Context;
        }

    }
}
