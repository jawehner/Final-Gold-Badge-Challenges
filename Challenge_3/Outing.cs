using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    enum EventType { Golf = 1, Bowling, AmusementPark, Concert }
    class Outing
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfPeople { get; set; }
        public string DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostOfEvent { get; set; }

        public Outing(EventType typeOfEvent, int numberOfPeople,
            string dateOfEvent, decimal costPerPerson, decimal costOfEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            CostOfEvent = costOfEvent;
        }

        public Outing()
        {

        }

    }
}
