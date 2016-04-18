using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Gig
    {
        public String name {get;set;}
        public String genre { get; set;}
        public String venue { get; set;}
        public DateTime dateTime{get;set;}

        public Gig(String name, String genre, String venue, DateTime dateTime)
        {
            this.name = name;
            this.genre = genre;
            this.venue = venue;
            this.dateTime = dateTime;
        }
    }
}