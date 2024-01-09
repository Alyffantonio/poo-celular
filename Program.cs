using System.Reflection;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Tijolão", imei:"121212", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("WildRift");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"123321", modelo:"15-PRO", imei:"445566", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");