using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C
{
    class Program
    {
        static void Main(string[] args)

        {
            int base_state = 0;
            while (true)
            {
                Console.WriteLine("chack the light state");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case -1:
                        switch (base_state)
                        {
                            case -1:
                                Console.WriteLine("the light was already broken");
                                break;
                            default:
                                Console.WriteLine("the light is now broken");
                                base_state = choise;
                                break;
                        }
                        break;
                    case 0:
                        switch (base_state)
                        {
                            case -1:
                                Console.WriteLine("the light is already broken you cant turn it off");
                                break;
                            default:
                                Console.WriteLine("the light is now off");
                                base_state = choise;
                                break;
                        }
                        break;
                    case 1:
                        switch (base_state)
                        {
                            case -1:
                                Console.WriteLine("the light is already broken so you cant turn it on");
                                break;
                            default:
                                Console.WriteLine("the light is now on!");
                                base_state = choise;
                                break;
                        }
                        break;
                    default:
                        switch (base_state)
                        {
                            case -1:
                                Console.WriteLine("now the light is fixed");
                                base_state = 0;
                                break;
                            default:
                                Console.WriteLine("no need the light is not broken");
                                break;
                        }
                        break;
                
                }
                if (choise == 10)
                {
                    break;
                }
                
            }
        }
    }
}
