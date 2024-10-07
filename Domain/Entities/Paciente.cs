using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Paciente")]
    public class Paciente
    {
        
        
        [Key]
       // public int id { get; set; }
        public int id_paciente { get; set; }
        [Column("cpf_cnpj")]
        [Display(Name = "Cpf ou Cnpj paciente: ")]
        public string cpf_cnpj { get; set; }


        [Column("nome")]
        [Display(Name = "Nome paciente: ")]
        public string nome { get; set; }
        [Column("endereco")]
        [Display(Name = "Endereco paciente: ")]
        public string endereco { get; set; }

        [Display(Name = "Telefone paciente: ")]
        public string telefone { get; set; }

        [Display(Name = "Email paciente: ")]
        public string email { get; set; }

      
        [Display(Name = "Digite F ou J (fisico ou juridico): ")]
        public string tipo_paciente { get; set; }


        [Display(Name = "Senha paciente: ")]
        public string senha { get; set; }
    }
}
