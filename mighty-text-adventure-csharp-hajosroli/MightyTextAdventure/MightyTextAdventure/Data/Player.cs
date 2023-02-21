namespace MightyTextAdventure.Data;

public class Player
{
    public String name { get; set; } = "DefaultPlayer";
    public Areas location { get; set; } = Areas.BedRoom;
    public int money { get; set; } = 154280; //minimálbér

    public Player(string input)
    {
        name = input;
    }

    public Areas setLocation(Areas newLocation)
    {
        location = newLocation;
        return location;
    }

    public int setMoney(int change)
    {
        money += change;
        return money;
    }
}