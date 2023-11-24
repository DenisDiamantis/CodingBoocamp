namespace GameAssignment
{
    public class Dragon : Character
    {
        public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            System.Console.WriteLine(this.name + " is a dragon.");
        }
        public void BreatheFire(Character target, bool defence)
        {
            //activate target defence
            if (defence) { target.Defend(); }
            if ((this.attack + 30) > target.defense)
            {
                int damage = (this.attack + 15) - target.defense;
                System.Console.WriteLine(this.name + " breathes fire at " + target.name + " for " + damage + " damage!");

                target.health -= damage;
            }
            else
            {
                System.Console.WriteLine(this.name + "'s attack has no effect on " + target.name);
            }
            //deactivate target defence
            if (defence) { target.Defend(); }
        }
        public override void Attack(Character target, bool defence)
        {
            if ((this.attack * 2) > target.defense)
            {
                int damage = (this.attack * 2) - target.defense;
                System.Console.WriteLine(this.name + " attacks " + target.name + " for " + damage + " damage!");
                target.health -= damage;
            }
            else
            {
                System.Console.WriteLine(this.name + "'s attack has no effect on " + target.name);
            }
        }
        public override void Defend()
        {
            if (this.turn)
            {
                this.defense += 15;
                System.Console.WriteLine(this.name + " hardens his scales' to defend.");
            }
            else
            {
                this.defense -= 15;
            }
            this.turn = !this.turn;

        }
    }
}
