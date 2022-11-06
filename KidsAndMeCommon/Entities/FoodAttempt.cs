namespace KidsAndMeCommon.Entities;

public class FoodAttempt:BaseEntity
{
    public FoodType FoodType { get; set; }
    public ConsumptionType ConsumptionType { get; set; }
    public double Quantity { get; set; }
    public DateTime Date { get; set; }
    public double EatingDuration { get; set; }
    public FoodSupply FoodSupply { get; set; }
    public string ChildReaction { get; set; }
}