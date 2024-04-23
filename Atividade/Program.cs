using System;
namespace Atividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            int consulta;
            do
            {
                float valorCompra;
                Console.WriteLine("Informe o nome da pessoa física ou jurídica:");
                string vNome = Console.ReadLine();
                Console.WriteLine("Informe o endereço:");
                string vEndereco = Console.ReadLine();

                Console.WriteLine("Digite 1 para Pessoa Física ou 2 para Pessoa Jurídica:");
                string pessoa = Console.ReadLine();
                if (pessoa == "1")
                {

                    Pessoa_Fisica pessoaFisica = new Pessoa_Fisica();
                    pessoaFisica.nome = vNome;
                    pessoaFisica.endereco = vEndereco;
                    Console.WriteLine("Informe o CPF:");
                    pessoaFisica.cpf = Console.ReadLine();
                    Console.WriteLine("Informe o RG:");
                    pessoaFisica.rg = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    valorCompra = float.Parse(Console.ReadLine());
                    pessoaFisica.Pagar_Imposto(valorCompra);

                    Console.WriteLine("\n" +
                    $"Nome............: {pessoaFisica.nome}\n"+
                    $"CPF.............: {pessoaFisica.cpf}\n" +
                    $"RG..............: {pessoaFisica.rg}\n"+
                    $"Valor da compra.: {valorCompra}R$\n" +
                    $"Imposto.........: {pessoaFisica.valor_imposto}R$\n"+
                    $"Total a pagar...: {pessoaFisica.total}R$");




                }
                else if (pessoa == "2")
                {
                    Pessoa_Juridica pessoaJuridica = new Pessoa_Juridica();
                    pessoaJuridica.nome = vNome;
                    pessoaJuridica.endereco = vEndereco;
                    Console.WriteLine("Informe o CNPJ:");
                    pessoaJuridica.cnpj = Console.ReadLine();
                    Console.WriteLine("Informe o IE:");
                    pessoaJuridica.ie = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    valorCompra = float.Parse(Console.ReadLine());
                    pessoaJuridica.Pagar_Imposto(valorCompra);

                    Console.WriteLine("\n"+
                    $"Nome............: {pessoaJuridica.nome}\n" +
                    $"CNPJ............: {pessoaJuridica.cnpj}\n" +
                    $"IE..............: {pessoaJuridica.ie}\n" +
                    $"Valor da compra.: {valorCompra}R$\n" +
                    $"Imposto.........: {pessoaJuridica.valor_imposto}R$\n" +
                    $"Total a pagar...: {pessoaJuridica.total}R$");

                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
                Console.WriteLine("Tecle 1 para uma nova consulta ou outra tecla para sair:");
                consulta = int.Parse(Console.ReadLine());
            }
            while (consulta == 1);
        }
    }
}



