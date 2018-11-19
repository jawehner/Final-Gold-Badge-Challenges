using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepository
    {
        List<Outing> _outings = new List<Outing>();

        public void AddOutingToList(Outing outing)
        {
            _outings.Add(outing);
        }

        public List<Outing> GetOutingsList()
        {
            return _outings;
        }

        public void DisplayCostOfAllOutings()
        {

            foreach (Outing outing in _outings)
            {

            }



        }
    }
}
