using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleTeam8.Models
{
    [Table("Files")]
    public class Files
    {
        [Key]
        public string namefile { get; set; }
        public string path { get; set; }
        public string note { get; set; }
        public virtual ICollection<Folder> folder { get; set; }
        public override string ToString()
        {
            return this.namefile;
        }
    }
}
