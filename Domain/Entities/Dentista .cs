using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Dentista")]
    public class Dentista
    {
        
        

            [Key]
            // public int id { get; set; }
            public int id_dentista { get; set; }
            [Column("cpf_cnpj")]

            [Display(Name = "Cpf dentista: ")]
            public string cpf { get; set; }
       
            [Display(Name = "numero_cro  dentista: ")]
            public string numero_cro { get; set; }


            [Column("nome")]
            [Display(Name = "Nome dentista: ")]
            public string nome { get; set; }
             
            [Column("telefone ")]
            [Display(Name = "telefone dentista: ")]
            public string telefone { get; set; }

            [Column("email  ")]
            [Display(Name = "email  dentista: ")]
            public string email { get; set; }


    }
}

