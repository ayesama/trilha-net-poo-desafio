﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "35648125", modelo: "N95", imei: "52421542154", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Wild Rift");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "985467851", modelo: "XS", imei: "124578454126", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tower of Fantasy");