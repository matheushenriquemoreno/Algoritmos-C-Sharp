﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogs.InputModel
{
    public class JogoInputModel
    {               
                    // validações em tela pra evitar dados errados chegar no controller 

        [Required] 
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do Jogo deve conter enter 3 a 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter enter 3 a 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome da categoria deve conter enter 3 a 50 caracteres")]
        public string Categoria { get; set; }

        [Required]
        [Range(1,10000, ErrorMessage = "O preço dever ser entre R$ 1.00 real a R$ 10.000")]
        public double Preco { get; set; }



    }
}
