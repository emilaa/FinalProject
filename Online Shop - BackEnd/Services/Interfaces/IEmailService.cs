namespace Online_Shop___BackEnd.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body);
    }
}
