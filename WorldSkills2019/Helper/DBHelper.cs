using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSkills2019.Database;

namespace WorldSkills2019.Helper
{
    public class DBHelper
    {
        private static Session2Entities context = new Session2Entities();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Session2Entities GetContext()
        {
            return context;
        }
    }
}
