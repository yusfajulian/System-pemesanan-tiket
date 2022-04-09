using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Helper
{
    public class BanyakBantuan
    {
        public static int BuatOTP()
        {
            Random mulai = new Random();

            int nilainya = mulai.Next(1000, 9999);
            return nilainya;
        }

        public static Object BuatResponAPI(string status, int respon_code, string message, object data)
        {
            return new
            {
                status,
                respon_code,
                message,
                data
            };
        }
    }
}
