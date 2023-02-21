using MightyTextAdventure.Data;
using MightyTextAdventure.Data.Places;
using MightyTextAdventure.UI;

namespace MightyTextAdventure;

public class Game
{
    private readonly Area[] _areas;

    private readonly Input _input;
    private readonly Display _display;

    public Game()
    {
        _areas = new Area[7];
        _input = new Input();
        _display = new Display();
    }

    public void Init()
    {
        LoadArea();
    }

    public void Run()
    {
        bool isRunning = true;
        while (isRunning)
        {
            isRunning = Step();
        }
    }

    private void LoadArea()
    {
        _areas[0] = new Area(Areas.BedRoom);
        _areas[1] = new Area(Areas.Bathroom);
        _areas[2] = new Area(Areas.Kitchen);
        _areas[3] = new Area(Areas.Tesco);
        _areas[4] = new Area(Areas.GasStation);
        _areas[5] = new Area(Areas.Home);
        _areas[6] = new Area(Areas.PostOffice);
        _areas[7] = new Area(Areas.Pharmacy);
        _areas[8] = new Area(Areas.Pub);
    }


    private bool Step()
    {
        _display.PrintMessage("steps");
        return true;
    }
}
