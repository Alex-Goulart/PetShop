namespace PetShop.Modelos
{
    internal class MedicoVeterinario
    {
        public MedicoVeterinario(string nome, string cRMV)
        {
            Nome = nome;
            CRMV = cRMV;
        }

        public string Nome { get; }
        public string CRMV { get; }
    }
}
