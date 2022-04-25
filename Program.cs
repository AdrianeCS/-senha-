string senhaCorreta = "1234";
string senhaDigitada, permissãoAcesso;

Console.Write("olá, professor, porfavor digite sua senha...:");
senhaDigitada = Console.ReadLine()!;

 permissãoAcesso= senhaDigitada == senhaCorreta?"permitido":"negado";

Console.WriteLine($"Acesso { permissãoAcesso }");
