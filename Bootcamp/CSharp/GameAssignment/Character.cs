namespace GameAssignment
{
    public class Character
    {
        public string name;
        public int health;
        public int attack;
        public int defense;
        //activate/deactivate defense status if attacked
        public bool turn = true;
        //static health to reset
        static int maxHealth;

        public Character(string name, int health, int attack, int defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
            maxHealth = health;
        }

        public virtual void Attack(Character target, bool defence)
        {
            //activate target defence
            if (defence) { target.Defend(); }
            if (this.attack > target.defense)
            {
                int damage = this.attack - target.defense;
                System.Console.WriteLine(this.name + " attacks " + target.name + " for " + damage + " damage!");
                target.health -= damage;
            }
            else
            {
                System.Console.WriteLine(this.name + "'s attack has no effect on " + target.name);
            }
            //deactivate target defence
            if (defence) { target.Defend(); }
        }
        public virtual void Defend()
        {
            if (this.turn)
            {
                this.defense += 5;
                System.Console.WriteLine(this.name + " is defending.");
            }
            else
            {
                this.defense -= 5;
            }
            this.turn = !this.turn;


        }
        //reset health lost
        public void resetHealth()
        {
            this.health = maxHealth;
        }

    }
}
