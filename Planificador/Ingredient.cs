namespace Planificador
{
    public class Ingredient
    {
        public Ingredient(string name, string quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
    }
}