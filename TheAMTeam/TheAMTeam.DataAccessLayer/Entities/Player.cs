﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAMTeam.DataAccessLayer.Entities
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }

        [StringLength(20, ErrorMessage ="Name Length can not exceed 20")]
        public string Name { get; set; }

        public int Team { get; set; }

        public int TshirtNO { get; set; }
        
        public DateTime? BirthDate { get; set; }

        [StringLength(20, ErrorMessage = "NameAlias Length can not exceed 20")]
        public string NameAlias { get; set; }

        public int? NationalityId { get; set; }


    }
}
