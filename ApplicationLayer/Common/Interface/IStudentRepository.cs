using ApplicationLayer.Module.Registration.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Common.Interface
{
    public interface IStudentRepository
    {
        Task<bool> IsStudentRegisteredAsync(string studentId);
        Task IsStudentRegisteredAsync(StudentRegistrationCommand command);
        Task RegisterStudentAsync(string studentId, string studentName); 
    }
}
