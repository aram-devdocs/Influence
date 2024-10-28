namespace Shared;

public class Entity
{
    public string Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Entity(string id, int x, int y)
    {
        this.Id = id;
        this.X = x;
        this.Y = y;
    }

}
