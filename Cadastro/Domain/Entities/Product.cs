using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Domain.Entities
{
    public class Product: BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Ative { get; set; }
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}