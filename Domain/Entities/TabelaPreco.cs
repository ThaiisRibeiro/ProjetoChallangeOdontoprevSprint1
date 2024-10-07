using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("TabelaPreço")]
    public class TabelaPreco
    {
       
     


            [Key]
            // public int id { get; set; }
            public int id_tabela_preco { get; set; }
            [Column("nome_procedimento ")]
            [Display(Name = "Nome do procedimento: ")]
            public string nome_procedimento { get; set; }


            [Column("valor ")]
            [Display(Name = "valor : ")]
            public double valor { get; set; }
            
            [Column("descricao ")]
            [Display(Name = "descricao tabela paciente: ")]
            public string descricao { get; set; }
    }
    }

