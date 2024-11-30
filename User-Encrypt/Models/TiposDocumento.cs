using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User_Encrypt.Models
{
    public class TiposDocumento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(2, MinimumLength = 4, ErrorMessage = "Este campo debe tener entre 2 a 4 caracteres")]
        public string Title { get; set; }
    }
}
