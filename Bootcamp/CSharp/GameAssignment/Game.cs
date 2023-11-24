namespace GameAssignment
{
    public class Game
    {
        public void Fight(Character c1, Character c2)
        {
            //reset the health of the fighters
            c1.resetHealth();
            c2.resetHealth();
            //create random variable to add chance modifier
            Random turn = new Random();
            System.Console.WriteLine();
            Console.WriteLine($"---- Battle between {c1.name} and {c2.name} ----");
            System.Console.WriteLine();
            while (c1.health > 0 && c2.health > 0)
            {
                //50/50 chance to get a turn
                if (turn.Next(2) == 0)
                {
                    Console.WriteLine("\n-----------" + c1.name + "'s turn.-----------");
                    Console.WriteLine(c1.name + " is preparing to attack " + c2.name + ".");

                    //check type of attacker and chance for their special attack
                    if (c1.GetType() == typeof(Warrior) && turn.Next(2) == 1)
                    {

                        ((Warrior)c1).Charge(c2, turn.Next(2) == 1);
                    }
                    else if (c1.GetType() == typeof(Mage) && turn.Next(2) == 1)
                    {
                        ((Mage)c1).CastSpell(c2, turn.Next(2) == 1);
                    }
                    //dragons also have different base attack
                    else if (c1.GetType() == typeof(Dragon))
                    {
                        if (turn.Next(4) == 1)
                            ((Dragon)c1).BreatheFire(c2, turn.Next(3) == 1);
                        else ((Dragon)c1).Attack(c2, turn.Next(2) == 1);
                    }
                    else
                    //warrior/mage base character attack
                    {
                        c1.Attack(c2, turn.Next(2) == 1);
                    }


                }
                else
                {

                    Console.WriteLine("\n-----------" + c2.name + "'s turn.-----------");
                    Console.WriteLine(c2.name + " is preparing to attack " + c1.name + ".");
                    if (c2.GetType() == typeof(Warrior) && turn.Next(2) == 1)
                    {

                        ((Warrior)c2).Charge(c1, turn.Next(2) == 1);
                    }
                    else if (c2.GetType() == typeof(Mage) && turn.Next(2) == 1)
                    {
                        ((Mage)c2).CastSpell(c1, turn.Next(2) == 1);
                    }
                    else if (c2.GetType() == typeof(Dragon))
                    {
                        if (turn.Next(4) == 1)
                            ((Dragon)c2).BreatheFire(c1, turn.Next(2) == 1);
                        else ((Dragon)c2).Attack(c1, turn.Next(2) == 1);
                    }
                    else
                    {
                        c2.Attack(c1, turn.Next(2) == 1);
                    }
                }
            }
            if (c1.health <= 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"-------------{c2.name} wins!-------------");
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"-------------{c1.name} wins!-------------");
                Console.WriteLine("---------------------------------------");
            }

        }
    }
}
