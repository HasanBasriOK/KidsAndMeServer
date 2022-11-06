namespace KidsAndMeCommon.Entities;

public class BreastMilkingDto : BaseEntity
{
    public DateTime Date { get; set; }
    public FoodSupply Chest { get; set; }
    public double Quantity { get; set; }
    public double Duration { get; set; }
}