namespace PetShop.Modelos
{
    internal class Consulta
    {
        public Consulta(Pet pet, MedicoVeterinario veterinario, DateTime data, string diagnostico)
        {
            Pet = pet;
            Veterinario = veterinario;
            Data = data;
            Diagnostico = diagnostico;
        }

        public Pet Pet { get; }
        public MedicoVeterinario Veterinario { get; }
        public DateTime Data { get; }
        public string Diagnostico { get; }
    }
}
