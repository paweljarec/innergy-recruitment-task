using System.Collections.Generic;

namespace InnergyInterpreter.Models
{
    public class Material
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MaterialQuantity> MaterialQuantities { get; set; }
    }
}
