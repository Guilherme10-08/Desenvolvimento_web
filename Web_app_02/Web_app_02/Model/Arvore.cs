using System.ComponentModel.DataAnnotations;

namespace Web_app_02.Classes
{
	public class Arvore
	{
		public int id_Arvore { get; set; }

		[Required(ErrorMessage = "Informe o nome da árvore!")]
		[MaxLength(30, ErrorMessage = "O campo nome deve conter no máximo 30 caracteres!")]
		[MinLength(5, ErrorMessage = "O campo nome deve conter no mínimo 5 caracteres!")]
		public string nome_Arvore { get; set; } = String.Empty;

		[Required(ErrorMessage = "Informe o nome do fruto da árvore!")]
		[MaxLength(30, ErrorMessage = "O campo nome fruto deve conter no máximo 30 caracteres!")]
		[MinLength(3, ErrorMessage = "O campo nome fruto deve conter no mínimo 3 caracteres!")]
		public string? nome_Fruto_Arvore { get; set; }

		[Required(ErrorMessage = "Informe a idade da árvore!")]
		[Range(1,100,ErrorMessage = "O campo idade árvore não pode conter valor zero!")]
		public int idade_Arvore { get; set; }

		[Required(ErrorMessage = "O campo vida arvore não pode ser vazio!")]
		public bool vida_Arvore { get; set; } = true;


	}
}
