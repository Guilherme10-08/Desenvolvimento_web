using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace Web_app_02.Classes
{
	public class Desenvolvimento
	{
		[Required(ErrorMessage = "Digite o nome da cor que pretende mudar para o fundo!")]
		public  string Cor { get; set; } = string.Empty;
		public static string Tema { get; set; } = "Desenvolvimento Web";

		public static string[] linguagens = new string[3] { "HTML5", "CSS3", "C#" };

		public static List<string> Lista_sgbd = new List<string>();

		[Parameter]
		public EventCallback Evento { get; set; }

		public void Sgbs()
		{
			Lista_sgbd.Add("MySql");
			Lista_sgbd.Add("SqlServer");
			Lista_sgbd.Add("Oracle");
		}

		public static void Mudar_Tema()
		{
			Tema = "Desenvolvedor FullStack";
		}
		public void Cor_de_Fundo(KeyboardEventArgs args)
		{
			if (args.Key == "A" || args.Key == "a")
			{
				Cor = "aqua";
			}
			
		}
		public void Cor_de_Fundo_2()
		{
			Cor = this.Cor.ToLower();
		}

	}

}
