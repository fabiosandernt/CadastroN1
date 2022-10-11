using System.Collections.Generic;

namespace Cadastro.Domain.Entities
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
