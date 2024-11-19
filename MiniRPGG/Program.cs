using MiniRPG;

namespace MiniRPGG;

class Program
{
    static void Main(string[] args)
    {
        Hero Garen = new Hero("Garen", 100, 1000, 15, 3);
        Ennemy Sbire = new Ennemy();

        GameManager.GameLoop(Garen, Sbire);

    }
}

