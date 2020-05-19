namespace InnergyInterpreter.Models
{
    public class MaterialQuantity
    {
        public virtual Material Material { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
    }
}
