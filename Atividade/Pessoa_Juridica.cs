namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void Pagar_Imposto(float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
