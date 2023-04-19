using System.Security.Cryptography;
    
    Console.Clear();
    int Faces, Rolagem;

    Console.Write("Insira Quantidade de Faces do dado: ");
    Faces = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    Rolagem = RandomNumberGenerator.GetInt32(1, Faces + 1);

    Console.WriteLine($"O número da rolagem é: {Rolagem}"); 