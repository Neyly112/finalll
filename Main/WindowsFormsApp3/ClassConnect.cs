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
<<<<<<< Updated upstream
            this.sqlConect = @"Data Source=MSI;Initial Catalog=QLCH2;Integrated Security=True;";
=======
            this.sqlConect = @"Data Source=TANNHA\TANNHA;Initial Catalog=QLCH2;Integrated Security=True;";
>>>>>>> Stashed changes
        }
        public string SqlConect()
        {
            return this.sqlConect;
        }
    }
}
