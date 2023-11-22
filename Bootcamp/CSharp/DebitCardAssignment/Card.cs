
namespace DebitCardAssignment
{
    public class Card
    {
        private string _pin;

        public string Pin
        {
            get => _pin;
            set
            {

                if (value.Length == 4 || value.Length == 6)
                {
                    bool valid = true;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] < 48 || value[i] > 58)
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        _pin = value;
                        System.Console.WriteLine("Pin successfully set up.");
                    }
                    else
                    {
                        System.Console.WriteLine("Pin cannot contain characters!");
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid pin length.");
                }

            }
        }
    }
}
