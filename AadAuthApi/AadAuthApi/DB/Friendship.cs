using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AadAuthApi.DB
{
    public class Friendship
    {
        public int Id { get; set; }

        public string FirstUser { get; set; }
        public string SecondUser { get; set; }
    }
}
