namespace PetShop.Modelos
{
    internal class Pet
    {
        public Pet(string nome, string especie, string raca, int idade, string dono)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Dono = dono;
        }

        public string Nome { get; }
        public string Especie { get; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public string Dono { get; set; }
    }
}
