using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paramore.Brighter;

namespace ApplicationLayer.Module.Registration.Commands
{
    public class StudentRegistrationCommand : Command
    {
        public int Id { get; set; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? Email { get; init; }
        public string? Password { get; init; }
        public string? Address { get; init; }
        public int Phone { get; init; }
        public StudentRegistrationCommand(string firstName, string lastName, string email, string password, string address, int phone) : base(Guid.NewGuid())
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;

        }

    }
}
