using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "123465", imei: "11111111", memoria: 64, modelo: "Modelo 1");
nokia.Ligar();
nokia.InstalarAplicativo("Coin Master");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "456789", imei: "2222222", memoria: 256, modelo: "iphone 14 pro max");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clear Corretora");
