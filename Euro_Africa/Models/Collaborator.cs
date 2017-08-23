using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Euro_Africa.Models
{
    public class Collaborator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Collaborator_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Description { get; set; }

    }
}