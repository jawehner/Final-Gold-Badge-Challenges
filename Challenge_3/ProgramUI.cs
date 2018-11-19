using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        List<Outing> outings;
        OutingRepository _outingRepo = new OutingRepository();
        public void Run()
        {
            outings = _outingRepo.GetOutingsList();
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

            newOuting.CostOfEvent = newOuting.NumberOfPeople * newOuting.CostPerPerson;

            _outingRepo.AddOutingToList(newOuting);

        }

        public void DisplayAllOutings()
        {

            foreach (Outing outing in outings)
            {
                Console.WriteLine($"Event type:{outing.TypeOfEvent} \nAttendees: {outing.NumberOfPeople}" +
                    $"\nDate of event: {outing.DateOfEvent} \nPrice per person: {outing.CostPerPerson}" +
                    $"\nTotal cost of event: {outing.CostOfEvent}\n");
            }
        }
        public void DisplayCostOfAllOutings()
        {
            List<Outing> outings = _outingRepo.GetOutingsList();
            decimal costOfAllOutings = 0m;
            foreach (Outing outing in outings)
            {
                costOfAllOutings += outing.CostOfEvent;
            }
            Console.WriteLine(costOfAllOutings);
        }

        private void DisplayCostOfAllOutingsByType()
        {
            List<Outing> outings = _outingRepo.GetOutingsList();
            Console.WriteLine("Enter the type of outing you would wish to see the total cost of:" +
                "1 = Golf, 2 = Bowling, 3 = Amusement Park, 4 = Concert");
            int input = int.Parse(Console.ReadLine());
            decimal golfTotalCost = 0m;
            decimal bowlingTotalCost = 0m;
            decimal amusementParkTotalCost = 0m;
            decimal concertTotalCost = 0m;
            switch (input)
            {

                case 1:
                    foreach (Outing outing in outings)
                    {
                        if(outing.TypeOfEvent == EventType.Golf)
                        {
                            golfTotalCost += outing.CostOfEvent;
                        }
                    }
                    Console.WriteLine($"Golf total cost is: {golfTotalCost}");
                    break;
                case 2:
                    foreach (Outing outing in outings)
                    {
                        if (outing.TypeOfEvent == EventType.Bowling)
                        {
                            bowlingTotalCost += outing.CostOfEvent;
                        }
                    }
                    Console.WriteLine($"Bowling total cost is: {bowlingTotalCost}");
                    break;
                case 3:
                    foreach (Outing outing in outings)
                    {
                        if (outing.TypeOfEvent == EventType.AmusementPark)
                        {
                            amusementParkTotalCost += outing.CostOfEvent;
                        }
                    }
                    Console.WriteLine($"Amusement park total cost is: {amusementParkTotalCost}");
                    break;
                case 4:
                    foreach (Outing outing in outings)
                    {
                        if (outing.TypeOfEvent == EventType.Concert)
                        {
                            concertTotalCost += outing.CostOfEvent;
                        }
                    }
                    Console.WriteLine($"Concert total cost is: {concertTotalCost}");
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

