using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    class HashData
    {
        SHA256 mySHA256 = SHA256Managed.Create();
        byte[] hashValue;
        public string hash(string input)
        {
            byte[] b = input.ToCharArray();
            hashValue = mySHA256.ComputeHash(b);

        }
    }
}
