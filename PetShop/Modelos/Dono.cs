namespace PetShop.Modelos
{
    internal class Dono
    {
        public Dono(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string nome { get; }
        public string Endereco { get; }
        public string Telefone { get; }
    }
}
