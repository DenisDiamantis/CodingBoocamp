using GameAssignment;

class Program
{
    static void Main()
    {
        //Character creation
        Warrior c1 = new Warrior("Arthur", 100, 20, 10);
        Mage c2 = new Mage("Merlin", 80, 15, 5);
        Dragon c3 = new Dragon("Smaug", 200, 30, 20);
        Dragon c4 = new Dragon("Alduin", 200, 30, 20);
        System.Console.WriteLine();

        //battle simulations
        Game battle = new Game();
        battle.Fight(c1, c2);
        battle.Fight(c2, c3);
        battle.Fight(c4, c3);

    }
}