using PetShop.Modelos;

Console.WriteLine("Seja Bem Vindo ao PetShop Ame Seu Pet!!!");

Dono dono = new Dono(nome: "Alex",
                     endereco: "Rua: Almerinda Maria de Jesus, Nº561, Morro da Ema, Goianésia-GO",
                     telefone: "62 98525-2796");

Pet pet = new("Luna",
              "Canina",
              "Vira Lata",
              4,
              dono.nome);

MedicoVeterinario veterinario = new("Dr. Icaro", "GO304010");

Consulta consulta = new(pet, veterinario, DateTime.Now, "Vacinação Contra Rabica");

Console.WriteLine($"Pet: {consulta.Pet.Nome}");
Console.WriteLine($"Dono: {consulta.Pet.Dono}");
Console.WriteLine($"Veterinário: {consulta.Veterinario.Nome}");
Console.WriteLine($"Diagnóstico: {consulta.Diagnostico}");