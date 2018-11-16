using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();
            Queue<Claim> _claims;

        public void Run()
        {
            Claim firstClaim = new Claim(33, "Auto", "Accident", 2000, "04/25/18", "04/27/18", "yes");
            Claim secondClaim = new Claim(33, "House", "Toilet exploded", 2000, "04/25/18", "04/27/18", "yes");
            Claim thirdClaim = new Claim(33, "Theft", "Pancakes stolen", 400, "04/25/18", "04/27/18", "no");

            _claims = _claimRepo.GetClaims();
            _claims.Enqueue(firstClaim);
            _claims.Enqueue(secondClaim);
            _claims.Enqueue(thirdClaim);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. See All Claims" +
                    "\n2. Take Care Of Next Claim" +
                    "\n3. Enter New Claim" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        SeeAllClaims();
                        break;
                    case 2:
                        SeeNextClaim();
                        break;
                    case 3:
                        NewClaim();
                        break;
                    case 4:
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

        private void SeeAllClaims()
        {
            foreach (Claim claim in _claims)
            {
                Console.WriteLine(claim);
            }
        }

        private void SeeNextClaim() //--peek?
        {
            Console.WriteLine("Do you want to deal with this claim now? (y/n)" + _claims.Peek());
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                _claims.Dequeue();
            }

            else if (answer == "n")
            {

            }
            //--What do? 

        }

        private void NewClaim()
        {
            Claim newClaim = new Claim();

            Console.WriteLine("Enter claim ID number");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the claim type");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter claim descrption");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter amount of damage");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of accident");
            newClaim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Enter date of claim");
            newClaim.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Was claim made within 30 days of incident?");
            newClaim.Validity = Console.ReadLine();

            _claims.Enqueue(newClaim);

            //--add claim to queue? enqueue?
            //-- DateTime? TimeSpans>
        }

    }
}
