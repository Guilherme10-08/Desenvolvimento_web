namespace Web_app_02.Classes
{
	public class Mensagem
	{
		public static string Sms_sucesso { get; set; } = string.Empty;

		public static string Sms_nao_sucesso { get; set; } = string.Empty;
		public static void Sms()
		{
			Sms_sucesso = "Venda efeituada com sucesso!";

		}
	}
}
