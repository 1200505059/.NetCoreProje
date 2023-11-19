using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class TodoList
    {
        [Key]
        public int ID { get; set; }
        public String Content { get; set; }
        public bool Status { get; set; }
    }
}
