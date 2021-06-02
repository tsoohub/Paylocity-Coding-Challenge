namespace Models
{
    /// <summary>
    /// represents a dependent
    /// </summary>
    public class Dependent
    {
        public int DependentId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal BenefitCost { get; set; }
    }
}
