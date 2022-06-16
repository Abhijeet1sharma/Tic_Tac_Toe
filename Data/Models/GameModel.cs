using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GameModel
    {
        [Key]
        public int Id;

        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string PlayerX;

        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Player0;

        [ForeignKey("GameState")]
        public virtual int GameId { get; set; }

        public virtual GameStateModel GameState { get; set; }

        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Result;

        public DateTime dateTime;
    }
}