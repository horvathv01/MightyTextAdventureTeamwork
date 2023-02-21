using System.Data;

namespace MightyTextAdventure.Data.Places;

public class Area
{
    
    public Areas name { get; set; }
    public string description { get; set; }

    public Area(Areas Description)
    {
        name = Description;
        description = getDescription(Description);
    }
    
    public string getDescription(Areas areaName)
    {
        string BedRoom = "You wake up in the bedroom. You look at your phone and realize: IT'S PAYDAY! At the end of the day, your friends will be waiting for your at the pub for a well-earned drink. But now you realize that you are starving, and you also have to pee.";
        string BathRoom = "In the bathroom you notice that you're out of toilet paper and toothpaste.";
        string Kitchen = "In the kitchen you notice that your fridge is empty.";
        string Tesco = "At Tesco you can shop around to fill your inventory.";
        string GasStation = "You are at the Gas station where you need to fill your tank.";
        string Home = "Finally you are at Home sweet home, where you can do your thing, eat, fill your fridge with all the things you bought. You can have a beer, and it's here where you realize that you have a lot of bills to pay. ";
        string Pharmacy = "At the Pharmacy you can buy the drugs for all your sicknesses.";
        string PostOffice = "At the Post office you can pay your bills and try your luck with some lottery scratch tickets!";
        string Pub = "Finally you are at the pub! Your friends have been waiting for you! Depending on your remaining budget now you may go home sadly, have a good pint, or endulge in some serious imbebery.";
        return BedRoom;
    }

    public string getOptions(Areas areaName)
    {
        
    }
}
