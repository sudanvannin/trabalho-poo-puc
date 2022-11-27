using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace trabalho_poo_puc{
    class Arquivo{
        public static void leArquivo(){
            var json = File.ReadAllText("./input.txt");
            var customers = JsonConvert.DeserializeObject<List<Candidato>>(json);
            //var result = new Candidato();
            foreach (var item in customers){
                Console.WriteLine(item);
            }
        }
    }
}