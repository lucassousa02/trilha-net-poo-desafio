using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("942332324", "Modelo 2", "424242424242", 64 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("977456712", "Modelo 5", "121212121212", 64 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");