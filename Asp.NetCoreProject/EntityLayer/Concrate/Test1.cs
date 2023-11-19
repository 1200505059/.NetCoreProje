using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Test1
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

    }
}
