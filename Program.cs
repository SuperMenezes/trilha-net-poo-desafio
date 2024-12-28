using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

    Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
    Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);

    nokia.InstalarAplicativo("WhatsApp");
    nokia.InstalarAplicativo("Facebook");
    nokia.InstalarAplicativo("Instagram");

    iphone.InstalarAplicativo("WhatsApp");
    iphone.InstalarAplicativo("Facebook");
    iphone.InstalarAplicativo("Instagram");

    Console.WriteLine("Aplicativos instalados no Nokia:");
    foreach (var app in nokia.AplicativosInstalados)
    {
        Console.WriteLine(app);
    }

    nokia.ReceberLigacao();
    nokia.Ligar();

    iphone.ReceberLigacao();
    iphone.Ligar();

    Console.WriteLine("Aplicativos instalados no Iphone:");
    foreach (var app in iphone.AplicativosInstalados)
    {
        Console.WriteLine(app);
    }
