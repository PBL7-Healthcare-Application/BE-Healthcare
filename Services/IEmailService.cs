using BE_Healthcare.Models.EmailModel;

namespace BE_Healthcare.Services
{
    public interface IEmailService
    {
        void SendEmail(MessageModel message);
    }
}
