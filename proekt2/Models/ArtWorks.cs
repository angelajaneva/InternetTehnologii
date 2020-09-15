using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proekt.Models
{
    public class ArtWorks
    {
        [Key]
        public int Id { get; set; }
        public String name { get; set; }
        public String img { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public int artist_id { get; set; }
        public virtual Artist artist { get; set; }

        


    }
}