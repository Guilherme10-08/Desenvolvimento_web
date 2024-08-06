using System.ComponentModel.DataAnnotations;

namespace Web_app_02.Classes
{
	public class Produto
	{
		public int Id_produto { get; set; }

		[Required(ErrorMessage = "Informe o nome do produto!")]
		[MaxLength(9,ErrorMessage = "Este campo deve conter no máximo 9 caracteres!")]
		public string? Nome_produto { get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		public int Quantidade_stock_produto { get; set; }
		public string? Sms { get; set; }

		public void Mensagem_validado()
		{
			Sms = "Formulário Válido com sucesso!";
		}
		public void Mensagem_Invalidado()
		{
			Sms = "Upps..Formulário não Validado!";
		}
	}
	
}
