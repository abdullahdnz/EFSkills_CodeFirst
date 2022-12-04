using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFSkills_CodeFirst.Models.Class
{
    public class Yetenek
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
    }
}