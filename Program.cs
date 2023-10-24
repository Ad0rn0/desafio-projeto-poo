using desafio_projeto_poo.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new(numero: "123456789", modelo: "Nokia C1", imei: "359598694684192", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("\nSmartphone Iphone: ");
Iphone iphone = new(numero: "987654321", modelo: "Iphone 13", imei: "527248386651078", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
