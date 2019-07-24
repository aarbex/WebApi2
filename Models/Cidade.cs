using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Tamanho Inválido", MinimumLength = 5)]
        [Column(TypeName = "VARCHAR")]
        public string Nome { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "Tamanho Inválido", MinimumLength = 2)]
        [Column(TypeName = "CHAR")]
        public string UF { get; set; }
        [StringLength(8, ErrorMessage = "Tamanho Inválido", MinimumLength = 8)]
        [Column(TypeName = "VARCHAR")]
        public string CEP { get; set; }
    }
}