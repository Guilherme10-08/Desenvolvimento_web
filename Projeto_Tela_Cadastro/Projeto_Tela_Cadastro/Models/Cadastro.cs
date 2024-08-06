using System.ComponentModel.DataAnnotations;
namespace Projeto_Tela_Cadastro.Models
{
	public class Cadastro
	{
		[Required(ErrorMessage = "Informe o nome do usuário a ser cadastrado!")]
		public string nome_Cadastro { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe a área de formação do usuário a ser cadastrado!")]
		public string area_Formacao_Cadastro { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe o tempo de experiência do usuário na sua área de formação!")]
		[Range(1, 100, ErrorMessage = "O campo Tempo Experiência não pode conter valor 0")]
		public int tempo_Experiencia_Usuario_Cadastro { get; set; }

		[Required(ErrorMessage = "Informe o telefone do usuário a ser cadastrado!")]
		[Range(1,9999999999, ErrorMessage = "O campo Telefone não pode conter valor 0")]
		public int telefone_Usuario_Cadastro { get; set; }

		[Required(ErrorMessage = "Informe o E-mail do usuário a ser cadastrado!")]
		[EmailAddress(ErrorMessage = "E-mail inválido, Digite um e-mail válido!")]
		public string email_Usuario_Cadastro { get; set; } = string.Empty;

	}
}
