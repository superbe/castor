namespace Castor.Interfaces
{
	public interface IEmail
	{
		void SendEmail(string From, string Subject, string Message);
		void SendEmail(string To, string CC, string BCC, string Subject, string Message);
		void SendEmail(string[] To, string[] CC, string[] BCC, string Subject, string Message);
		void SendIndividualEmailsPerRecipient(string[] To, string Subject, string Message);
	}
}
