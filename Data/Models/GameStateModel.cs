using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GameStateModel
    {
        [Key]
        public int Id;

        public string TL;

        public string TR;

        public string TM;

        public string ML;

        public string MR;

        public string MM;

        public string BL;

        public string BM;

        public string BR;
    }
}