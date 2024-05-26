using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class ClassConnect
    {
        string sqlConect;
        public ClassConnect()
        {
            this.sqlConect = @"Data Source=MSI;Initial Catalog=QLCH2;Integrated Security=True;";
        }
        public string SqlConect()
        {
            return this.sqlConect;
        }
    }
}
