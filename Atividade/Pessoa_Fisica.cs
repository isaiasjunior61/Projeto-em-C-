namespace Atividade
{
    public class Pessoa_Fisica:Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        public override void Pagar_Imposto (float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }

    }
}