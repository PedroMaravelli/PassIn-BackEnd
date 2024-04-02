using PassIn.Communication.Requests;

namespace PassIn.Application.UseCases.Events.Register
{
    public class RegisterEventUseCase
    {
        public void Execute(RequestEventJson request)
        {


        }

        private void Validate(RequestEventJson request)
        {
            if(request.MaximumAttendees <= 0)
            {
                throw new ArgumentException("The maximum attendes is invalid ");
            }

            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new ArgumentException("The title is invalid");
            }
        }
    }
}
