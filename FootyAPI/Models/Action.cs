using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
{
    public class Action
    {
        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public int Minute { get; set; }
        public int PlayerId { get; set; }
    }
}
