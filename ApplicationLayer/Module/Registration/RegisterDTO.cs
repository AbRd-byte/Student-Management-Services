using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Module.Registration
{
    public class RegisterDTO
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }
    }
}
