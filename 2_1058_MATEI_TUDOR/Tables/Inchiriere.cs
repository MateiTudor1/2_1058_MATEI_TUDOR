using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1058_MATEI_TUDOR.Tables
{
    public class Inchiriere
    {
        public int IdInchiriere {  get; set; }
        public int IdClient { get; set; }
        public int IdFilm { get; set; }
        public float Pret { get; set; }
        public DateTime DataInchiriere { get; set; }
        public DateTime DataReturnare { get; set; }
    }
}
