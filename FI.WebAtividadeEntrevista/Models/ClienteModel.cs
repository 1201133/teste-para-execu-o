using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class ClienteModel
    {
        public long Id { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CEP { get; set; }

        //[RegularExpression("^[0-9]{14}$", ErrorMessage = "Esse não é um CPF válido")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string CPF { get; set; }
        

        /// <summary>
        /// CPF
        /// </summary>
        
        public string Cidade { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required]
        public string Logradouro { get; set; }

        /// <summary>
        /// Nacionalidade
        /// </summary>
        [Required]
        public string Nacionalidade { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Esse campo deve conter no máximo 50 letras")]
        public string Nome { get; set; }

        /// <summary>
        /// Sobrenome
        /// </summary>
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Esse campo deve conter no máximo 50 letras")]
        public string Sobrenome { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        /// 
        //[RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4,5}[-]{1}[0-9]{3,4}$", ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")] 
        public string Telefone { get; set; }

    }
}