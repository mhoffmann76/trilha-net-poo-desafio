using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "123456", modelo: "N37", imei: "09090909", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whastzap");

Console.WriteLine("\n------------------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "09098899", modelo: "15-PRO", imei: "0900999", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");



