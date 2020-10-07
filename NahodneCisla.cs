using System;
using System.Collections.Generic;

namespace konstruktorTets
{
    public class NahodneCisla
    {
        public List<int> ListCisel { get; set; }

        public NahodneCisla()
        {
            var rand = new Random();
            ListCisel = new List<int>{rand.Next()};
        }
    }
}