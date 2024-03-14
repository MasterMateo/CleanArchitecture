namespace GymManagement.Domain.Rooms;

public class Room
{
    public Room(
        string name,
        Guid gymId,
        int maxDailySessions,
        Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        Name = name;
        GymId = gymId;
        MaxDailySessions = maxDailySessions;
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid GymId { get; set; }
    public int MaxDailySessions { get; }

}
