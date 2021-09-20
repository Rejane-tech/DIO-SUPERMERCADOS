using System;

namespace DIO.Supermercados
{
    class Program
    {

        static CompraRepositorio repositorio = new CompraRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarCompra();
						break;
					case "2":
						InserirCompra();
						break;
					case "3":
						AtualizarCompra();
						break;
					case "4":
						ExcluirCompra();
						break;
					case "5":
						VisualizarCompra();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
        }

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirCompra()
		{
			Console.Write("Digite o id da compra: ");
			int indiceCompra = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceCompra);
		}

        private static void VisualizarCompra()
		{
			Console.Write("Digite o id da compra: ");
			int indiceCompra = int.Parse(Console.ReadLine());

			var compra = repositorio.RetornaPorId(indiceCompra);

			Console.WriteLine(compra);
		}

        private static void AtualizarCompra()
		{
			Console.Write("Digite o id da compra: ");
			int indiceCompra = int.Parse(Console.ReadLine());

						foreach (int i in Enum.GetValues(typeof(Secao)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Secao), i));
			}
			Console.Write("Digite a secao entre as opções acima: ");
			int entradaSecao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Produto da Compra: ");
			string entradaProduto = Console.ReadLine();

			Console.Write("Digite o Mes de fabricação do produto: ");
			int entradaMes = int.Parse(Console.ReadLine());

			Console.Write("Digite a Composicao do produto: ");
			string entradaComposicao = Console.ReadLine();

			Compra atualizaCompra = new Compra(id: indiceCompra,
										secao: (Secao)entradaSecao,
										produto: entradaProduto,
										mes: entradaMes,
										composicao: entradaComposicao);

			repositorio.Atualiza(indiceCompra, atualizaCompra);
		}
        private static void ListarCompra()
		{
			Console.WriteLine("Listar compra");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma compra cadastrada.");
				return;
			}

			foreach (var compra in lista)
			{
                var excluido = compra.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", compra.retornaId(), compra.retornaProduto(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirCompra()
		{
			Console.WriteLine("Inserir nova compra");

						foreach (int i in Enum.GetValues(typeof(Secao)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Secao), i));
			}
			Console.Write("Digite a secao entre as opções acima: ");
			int entradaSecao = int.Parse(Console.ReadLine());

			Console.Write("Digite o produto da Compra: ");
			string entradaProduto = Console.ReadLine();

			Console.Write("Digite o Mes de fabricacao do Produto: ");
			int entradaMes = int.Parse(Console.ReadLine());

			Console.Write("Digite a Composicao do Produto: ");
			string entradaComposicao = Console.ReadLine();

			Compra novaCompra = new Compra(id: repositorio.ProximoId(),
										secao: (Secao)entradaSecao,
										produto: entradaProduto,
										mes: entradaMes,
										composicao: entradaComposicao);

			repositorio.Insere(novaCompra);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Supermercado DIO a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar compra");
			Console.WriteLine("2- Inserir nova compra");
			Console.WriteLine("3- Atualizar compra");
			Console.WriteLine("4- Excluir compra");
			Console.WriteLine("5- Visualizar compra");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
        
    }
}
