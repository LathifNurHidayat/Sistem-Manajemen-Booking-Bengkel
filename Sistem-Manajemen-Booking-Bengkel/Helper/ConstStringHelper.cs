using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Booking_Bengkel.Helper
{
    public class ConstStringHelper
    {
        public static string GetConn()
        {
            return "Server=(local); Database= ; TrustServerCertificate = true; Trusted_Connection = true;";
        }
    }
}