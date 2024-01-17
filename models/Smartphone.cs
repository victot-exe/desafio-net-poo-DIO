using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_desafio_poo_DIO.models{
    public abstract class Smartphone{
        
        public string Numero { get; set; }
        // TODO: Passar as propriedades do diagrama.
        private string Modelo;
        private string IMEI;
        private int Memoria;

        private string ImeiGenerator(int lenght){
            Random random = new();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomKey = new string(Enumerable.Repeat(chars, lenght).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomKey;
        }

        public Smartphone(string numero, string modelo, int memoria){
            Numero = numero;
            // TODO: Passar os parametros do contrutor para as props
            Modelo = modelo;
            IMEI = ImeiGenerator(15);
            Memoria = memoria;
        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarApp(string nomeApp);

        public override string ToString(){
            // string infos = "Modelo: " + this.Modelo + "\nIMEI: " + this.IMEI + "\nA memória é de: " + this.Memoria + "GB" + "Para me ligar disque" + this.Numero;
            string infos = $"Modelo: {this.Modelo}\nIMEI: {this.IMEI}\nA memória é de: {this.Memoria} GB\nPara me ligar disque {this.Numero}";
            return infos;
        }
    }
}