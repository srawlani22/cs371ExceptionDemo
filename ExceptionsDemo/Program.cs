using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Starship Serenity = new Starship("Serenity", "Firefly", "404-E-132-4FE274A", 9);

           
            Serenity.AddCrew("Captain", "Malcolm Reynolds");
            Serenity.AddCrew("FirstMate", "Zoe Washburne");
            Serenity.AddCrew("Pilot", "Hoban Washburne");
            Serenity.AddCrew("Engineer", "Kaywinnet Lee Frye");
            Serenity.AddCrew("PublicRelations", "Jayne Cobb");
            Serenity.AddCrew("Ambassador", "Inara Serra");
            Serenity.AddCrew("Shepherd", "Derrial Book");
            Serenity.AddCrew("Medic", "Simon Tam");
            Serenity.AddCrew("Crew", "River Tam");
            Serenity.AddCrew("Crew", "Sparsh Rawlani");// for testing

            try { 
            

            if(Serenity.CurrentCrewSize() > Serenity.CrewCapacity)
                {
                    throw new ExtraCrewException("Too many people");
                }
           
                
            }
            catch (ExtraCrewException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
           
            Serenity.Print();
            Serenity.PrintRoster();
            Console.ReadLine();
        }
    }
}
