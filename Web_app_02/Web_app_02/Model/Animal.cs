using System.ComponentModel.DataAnnotations;
namespace Web_app_02.Model
{
	public class Animal
	{
		public int id_Animal { get; set; }

		[Required(ErrorMessage = "Informe o nome do animal")]
		public string nome_Animal { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe o nome da espécie do animal")]
		public string especie_Animal { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe o sexo do animal")]
		[MaxLength(10,ErrorMessage = "O campo sexo animal deve conter no máximo 10 caracteres")]
		public string sexo_Animal { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe a idade do animal")]
		[Range(1,100,ErrorMessage = "O campo idade animal não pode conter valor zero!")]
		public int idade_Animal { get; set; }

	}

}
