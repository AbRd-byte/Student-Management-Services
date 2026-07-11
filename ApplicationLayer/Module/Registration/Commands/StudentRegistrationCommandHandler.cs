using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using ApplicationLayer.Common.Interface;

namespace ApplicationLayer.Module.Registration.Commands
{
    public sealed class StudentRegistrationCommandHandler : RequestHandlerAsync<StudentRegistrationCommand>
    {
        public readonly IStudentRepository _studentRepository;

        public StudentRegistrationCommandHandler(IStudentRepository studentRepository) =>
            _studentRepository = studentRepository;

        public override async Task<StudentRegistrationCommand> HandleAsync(
            StudentRegistrationCommand command,
            CancellationToken cancellationToken = default)
        {
            await _studentRepository.IsStudentRegisteredAsync(command);
            return command;
        }
    }
}
