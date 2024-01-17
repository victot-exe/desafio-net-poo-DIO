// See https://aka.ms/new-console-template for more information
using trilha_net_desafio_poo_DIO.models;

Smartphone iPhone = new Iphone("12988786556", "12 Pro Max", 128);
Smartphone tijolo = new Nokia("12987654820", "tijolão", 256);

Console.WriteLine(tijolo.ToString());
Console.WriteLine(iPhone.ToString());