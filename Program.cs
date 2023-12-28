using DesafioPOO.Models;

Console.WriteLine("TESTE NOKIA");

Smartphone nokia = new Nokia (numero: "123", modelo: "Nokia G60 5G",imei: "111", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Twitch");

Console.WriteLine("\n");

Console.WriteLine("TESTE IPHONE");

Smartphone iphone = new Iphone (numero: "321", modelo: "Iphone 15 PRO",imei: "222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");
