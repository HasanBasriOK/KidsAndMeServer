namespace KidsAndMeCommon.Entities;

public class Creature : BaseEntity
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public Gender Gender { get; set; }
    public CreatureType CreatureType { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
}