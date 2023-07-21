using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Informar Tipo (f - Pessoa Física, j - Pessoa Jurídica)");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.CPF = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pf.RG = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                float val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome........: " + pf.Nome);
                Console.WriteLine("Endereço........: " + pf.Endereco);
                Console.WriteLine("CPF........: " + pf.CPF);
                Console.WriteLine("RG........: " + pf.RG);
                Console.WriteLine("Valor de Compra........: " + val_pag.ToString("C"));
                Console.WriteLine("Imposto........: " + pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar........: " + pf.Total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.IE = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                float val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome........: " + pj.Nome);
                Console.WriteLine("Endereço........: " + pj.Endereco);
                Console.WriteLine("CNPJ........: " + pj.CNPJ);
                Console.WriteLine("IE........: " + pj.IE);
                Console.WriteLine("Valor de Compra........: " + val_pag.ToString("C"));
                Console.WriteLine("Imposto........: " + pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar........: " + pj.Total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Tipo inválido. Use 'f' para Pessoa Física ou 'j' para Pessoa Jurídica.");
            }
        }
    }
}
