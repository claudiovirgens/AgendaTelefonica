﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage ="{0} é obrigatório")]
        [StringLength(40, ErrorMessage ="Maximo permitido 40 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Maximo permitido 40 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Range(18,int.MaxValue,ErrorMessage ="Idade Invalida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Maximo permitido 40 caracteres")]
        [EmailAddress(ErrorMessage ="Use menos caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public TipoTelefone TipoTelefone { get; set; }

        public string Foto { get; set; }

    }

    public enum TipoTelefone
    {
        Pessoal, Comercial
    }
}
