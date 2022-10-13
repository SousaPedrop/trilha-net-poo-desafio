using DesafioPOO.Models;

Console.WriteLine("Teste do Nokia: ");
Nokia n1 = new Nokia("40028922", "101010101", "Nokia1", 16);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Pou");

Console.WriteLine("==============================");

Console.WriteLine("Teste do Iphone: ");
Iphone i1 = new Iphone("11999887766", "010101010", "Iphone1", 64);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("PUBG");