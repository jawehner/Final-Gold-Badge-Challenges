using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("What would you like to do?" +
                    "\n1. Add outing event" +
                    "\n2. Display all outings" +
                    "\n3. Display cost of all outings" +
                    "\n4. Display costs of outings by type" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddOuting();
                        break;
                    case 2:
                        DisplayAllOutings();
                        break;
                    case 3:
                        DisplayCostOfAllOutings();
                        break;
                    case 4:
                        DisplayCostOfAllOutingsByType();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void AddOuting()
        {
            Outing newOuting = new Outing();

            Console.WriteLine("Enter the type of event (golf, bowling, amusement park, or concert):");
            string input = Console.ReadLine();
            switch (input)
            {
                case "golf":
                    newOuting.TypeOfEvent = EventType.Golf;
                    break;
                case "bowling":
                    newOuting.TypeOfEvent = EventType.Bowling;
                    break;
                case "amusement park":
                    newOuting.TypeOfEvent = EventType.AmusementPark;
                    break;
                case "concert":
                    newOuting.TypeOfEvent = EventType.Concert;
                    break;
            }

            Console.WriteLine("Enter number of people in attendance:");
            newOuting.NumberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of event:");
            newOuting.DateOfEvent = Console.ReadLine();

            Console.WriteLine("Enter the cost per person:");
            newOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total cost of the event:");
            newOuting.CostOfEvent = decimal.Parse(Console.ReadLine());
        }

        private void DisplayAllOutings()
        {
            Console.WriteLine($");
        }

        private void DisplayCostOfAllOutingsByType()
        {
            throw new NotImplementedException();
        }
    }
}

