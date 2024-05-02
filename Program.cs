using DesafioPOO.Models;

// Realizei os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Iphone:");
        Iphone iphone = new Iphone(numero:"777",modelo:"Iphone",imei:"4333",memoria:128);
        iphone.Ligar();
        iphone.InstalarAplicativo("whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia(numero:"888", modelo:"Nokia", imei:"4777",memoria:64);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
        

