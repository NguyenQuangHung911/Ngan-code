using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ft
namespace KindleTeam8.Controllers
{
    public class DBTestController
    {
        public static void initializeDB()
        {
            using (var _conntext = new DBFolderContext())
            {
                var folder = new ClassFolder() { namefolder = "Library" };
                _conntext.tbFolders.Add(folder);
                _conntext.SaveChanges();
            }
            MessageBox.Show("Finish");
        }
    }
}
