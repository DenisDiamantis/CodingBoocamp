
namespace GameAssignment
{
    public class Mage : Character
    {
        public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
            System.Console.WriteLine(this.name + " is a mage.");
        }
        public void CastSpell(Character target, bool defence)
        {
            //activate target defence
            if (defence) { target.Defend(); }
            if ((this.attack + 25) > target.defense)
            {
                int damage = (this.attack + 25) - target.defense;
                System.Console.WriteLine(this.name + " casts spell at " + target.name + " for " + damage + " damage!");

                target.health -= damage;
            }
            else
            {
                System.Console.WriteLine(this.name + "'s attack has no effect on " + target.name);
            }
            //deactivate target defence
            if (defence) { target.Defend(); }
        }
        sealed public override void Defend()
        {
            if (this.turn)
            {
                System.Console.WriteLine(this.name + " casts Barrier to defend.");
                this.defense += 20;
            }
            else
            {
                this.defense -= 20;
            }
            this.turn = !this.turn;

        }
    }
}
