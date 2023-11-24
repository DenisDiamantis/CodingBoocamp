
namespace GameAssignment
{
    public class Warrior : Character
    {
        public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            System.Console.WriteLine(this.name + " is a warrior.");
        }

        public void Charge(Character target, bool defence)
        {
            //activate target defence
            if (defence) { target.Defend(); }
            if ((this.attack + 15) > target.defense)
            {
                int damage = (this.attack + 15) - target.defense;
                System.Console.WriteLine(this.name + " charches at " + target.name + " for " + damage + " damage!");
                target.health -= damage;
            }
            else
            {
                System.Console.WriteLine(this.name + "'s attack has no effect on " + target.name);
            }
            //deactivate target defence
            if (defence) { target.Defend(); }
        }
        public override void Defend()
        {
            if (this.turn)
            {
                this.defense += 10;
                System.Console.WriteLine(this.name + " raises his shield to defend.");
            }
            else
            {
                this.defense -= 10;
            }
            this.turn = !this.turn;

        }


    }
}
