using System.Transactions;

namespace MCNR
{
    internal class Program
    {

        static void NPC()
        {
            int choose;
            Console.WriteLine("Press 1 for cave or Press 2 for inventory:  ");
            int decision  = Console.ReadLine();
            if (decision == 1)
            {

            }
             

        }


            static void Introduction()
            {
                Console.WriteLine("In the peaceful realm of Eldoria, darkness has begun to creep into the lands, threatening the harmony of its inhabitants. <enter>");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("As a young hero named [Enter Name], you awaken to the call of adventure, armed only with your determination and a rusty sword. <enter>");
                string playersName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Your journey begins at the edge of your village, where whispers of a powerful foe—the Shadow Lord—stir fear in every heart. <enter>");
            }

            static void TutorialControl()
            {
                Console.WriteLine("You step into the world, ready to prove your worth. <enter>");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("A training dummy awaits, your first test. You must learn the art of combat by pressing 'A' to attack.");
                char attack = Convert.ToChar(Console.ReadLine());

            int enemy1;






        }



            static void Main(string[] args)
            {
                Introduction();
                Console.ReadLine();
            }
        }  
    }
        

