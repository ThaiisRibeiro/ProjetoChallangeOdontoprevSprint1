﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("ContasPagar")]
    public class ContasPagar
    {
        
     


            [Key]
            // public int id { get; set; }
            public int id_conta_pagar { get; set; }
           
            [Column("id_clinica ")]
            [Display(Name = "id_clinica : ")]
            public int id_clinica { get; set; }


            [Column("valor ")]
            [Display(Name = "valor : ")]
            public double valor { get; set; }
            
            [Column("data_emissao ")]
            [Display(Name = "data_emissao : ")]
            public DateTime data_emissao { get; set; }

           [Column("data_vencimento  ")]
           [Display(Name = "data_vencimento  : ")]
           public DateTime data_vencimento { get; set; }


          
    }

    }

