using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;

namespace Web_app_02.Classes
{
	public class Venda
	{
		public int id_Venda_Produto { get; set; }

		[Required(ErrorMessage = "Informe o nome do produto a ser vendido!")]
		[MaxLength(50, ErrorMessage = "O campo nome deve ter no máximo 50 caracteres!")]
		[MinLength(5, ErrorMessage = "O campo nome deve ter no mínimo 5 caracteres!")]
		public string? nome_Produto_Venda { get; set; }
		
		[Required(ErrorMessage = "Informe a quantidade do produto que pretende comprar!")]
		[Range(1,999999,ErrorMessage = "Informe pelo menos um produto!")]
		public int quantidade_Produto_Venda { get; set; }

		[Required(ErrorMessage = "Informe o valor pago pelo cliente!")]
		[Range(50,999999,ErrorMessage = "Valor pago inválido, Informe um valor válido!")]
		public Decimal valor_Pago_Produto { get; set; }

		[Required(ErrorMessage = "Informe o preço do produto!")]
		[Range(50, 999999, ErrorMessage = "Preço do produto inválido, Informe um preço válido!")]
		public Decimal Preco_Produto_Venda { get; set; }

		public Decimal total_Venda_Produto { get; set; }

		public Decimal troco_Venda_Produto { get; set; }

		public DateTime data_Venda_Produto { get; set; } = DateTime.Now;

		public void Vender_Produto_()
		{
			try
			{
				total_Venda_Produto = quantidade_Produto_Venda * Preco_Produto_Venda;

				if (valor_Pago_Produto <total_Venda_Produto)
				{
					Mensagem.Sms_nao_sucesso = "Valor insuficiente para compra!";

					return;
				}
				else
				{
					troco_Venda_Produto = valor_Pago_Produto - total_Venda_Produto;

					Mensagem.Sms_sucesso = "Venda efeituada com sucesso!";
				}


			}
			catch
			{
				Console.WriteLine("Erro ao efeituar a venda!");
			}

		}

	}
}
