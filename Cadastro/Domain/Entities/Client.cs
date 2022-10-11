using Cadastro.Controllers;
using System.Collections.Generic;

namespace Cadastro.Domain.Entities
{
    public class Client: BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Ative { get; set; }
        public List<Product>  Products { get; set; }
    }
}