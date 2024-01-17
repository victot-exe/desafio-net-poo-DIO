using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_desafio_poo_DIO.models{
    //Herdar Smartphone
    public class Iphone(string numero, string modelo, int memoria) : Smartphone(numero, modelo, memoria){
        public override void InstalarApp(string nomeApp){
            Console.WriteLine("Instalando aplicativo no iPhone...");
        }
    }
}