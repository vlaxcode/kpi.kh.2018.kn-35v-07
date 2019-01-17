using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Data.Entity
{
    public class Response
    {
        [Key]
        public int ID { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
