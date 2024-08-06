using Microsoft.AspNetCore.Components.Web;

namespace Web_app_02.Classes
{
	public class VendaProduto
	{
		Venda venda = new Venda();
		public void Vender_Produto()
		{
			try
			{
				venda.total_Venda_Produto = venda.quantidade_Produto_Venda * venda.Preco_Produto_Venda;

				if (venda.valor_Pago_Produto < venda.total_Venda_Produto)
				{
					Mensagem.Sms_nao_sucesso = "Valor insuficiente para compra!";

					return;
				}
				else
				{
					venda.troco_Venda_Produto = venda.valor_Pago_Produto - venda.total_Venda_Produto;

					Mensagem.Sms_sucesso = "Venda efeituada com sucesso!";
				}


			}
			catch
			{
				Console.WriteLine("Erro ao efeituar a venda!");
			}

		}
		public void Vender_Produto_(KeyboardEventArgs args)
		{
			if (args.Key == "Enter")
			{
				venda.total_Venda_Produto = venda.quantidade_Produto_Venda * venda.Preco_Produto_Venda;

				if (venda.valor_Pago_Produto < venda.total_Venda_Produto)
				{
					Mensagem.Sms_nao_sucesso = "Valor insuficiente para compra!";

					return;
				}
				else
				{
					venda.troco_Venda_Produto = venda.valor_Pago_Produto - venda.total_Venda_Produto;

					Mensagem.Sms_sucesso = "Venda efeituada com sucesso!";
				}
			}
		}
	}
}
