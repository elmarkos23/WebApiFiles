using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFiles.Models
{
    public class cancion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] archivo { get; set; }
        
        
    }
}