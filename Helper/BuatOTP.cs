using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Helper
{
    public static class BuatOTP
    {
        public static int buatOTP()
        {
            Random r = new();
            return r.Next(1000, 9999);
        }
    }
}
