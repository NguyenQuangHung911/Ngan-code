using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace KindleTeam8.Models
{
    [Table("Folder")]
    public class Folder
    {
        [Key]
        public string namefolder { get; set; }
        public virtual ICollection<Files> filename { get; set; }
        public override string ToString()
        {
            return this.namefolder;
        }
        //public List<Files> files { get; set; }
        //public List<Files> Returnlist()
        //{
        //    List<Files> file = new List<Files>();
        //    foreach(Files f in this.filename)
        //    {
        //        file.Add(f);
        //    }
        //    return file;
        //}    
    }
}
