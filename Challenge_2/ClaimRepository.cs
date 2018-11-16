using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> _claims = new Queue<Claim>();

        public void AddToClaims(Claim claim)
        {
            _claims.Enqueue(claim);
        }

        public Queue<Claim> GetClaims()
        {
            return _claims;
        }
    }
}
