using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTb01Lab1_AVR.Models
{
    public class Automovel
    {
        //PK
        public int AutomovelId { get; set; }
        [Required(ErrorMessage = "Tipo é obrigatório!")]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage ="Descrição tem que ser informada!")]
        [StringLength(300, ErrorMessage = "O maximo de caracteres é 300!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Marca tem que ser informada!")]
        [StringLength(100, ErrorMessage ="O maximo de caracteres é 100")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Disponivel tem que ser informado!")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "DataCadastro tem que ser informado! ")]
        public DateTime DataCadastro { get; set; }
    }
}