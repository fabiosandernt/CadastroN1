using Cadastro.Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "O produto é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Disponível")]
        public bool Ative { get; set; }

        [Required]
        public int ClientId { get; set; }

        public ClientViewModel Client { get; set; }
        public IEnumerable<ClientViewModel> Clients { get; set; }

    }
}
