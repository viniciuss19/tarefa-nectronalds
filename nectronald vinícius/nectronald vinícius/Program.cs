using System;
using System.Collections.Generic;

namespace nectronald_vinícius
{
    class Program
    {
        static void Main(string[] args)
        {
            string busca;
            string buscares;
            

            Restaurante NecBrasil = new Restaurante();
            NecBrasil.nome = "NecBrasil";
            NecBrasil.lanches = new List<lanches>();



            lanches NecFeijoada = new lanches();
            {
                NecFeijoada.nome = "NecFeijoada";
                NecFeijoada.descrição = "Lanche clássico com o gostinho Brasileiro.";
                NecFeijoada.preçolanche = 12.5f;
                NecBrasil.lanches.Add(NecFeijoada);

            }
            lanches NecBacon = new lanches();
            {
                NecBacon.nome = "NecBacon";
                NecBacon.descrição = "Um lanche delicioso para ser aproveitado com muito bacon";
                NecBacon.preçolanche = 12.5f;
                NecBrasil.lanches.Add(NecBacon);

            }
            lanches NecAcarajé = new lanches();
            {
                NecAcarajé.nome = "NecAcarajé";
                NecAcarajé.descrição = "Sinta o gostinho da Bahia neste lanche típico da cultura brasileira";
                NecAcarajé.preçolanche = 12.5f;
                NecBrasil.lanches.Add(NecAcarajé);

            }
            Restaurante NecArgentina = new Restaurante();
            NecArgentina.nome = "NecArgentina";
            NecArgentina.lanches = new List<lanches>();

            lanches NecPicanha = new lanches();
            {
                NecPicanha.nome = "NecPicanha";
                NecPicanha.descrição = "Desfrute do sabor argentino com muita picanha!";
                NecPicanha.preçolanche = 16f;
                NecArgentina.lanches.Add(NecPicanha);
            }
            lanches NecChimichurri = new lanches();
            {
                NecChimichurri.nome = "NecChimichurri";
                NecChimichurri.descrição = "Um lanche com o tempero chimichurri no hamburguer";
                NecChimichurri.preçolanche = 16f;
                NecArgentina.lanches.Add(NecChimichurri);
            }
            Restaurante NecMéxico = new Restaurante();
            {
                NecMéxico.nome = "NecMéxico";
                NecMéxico.lanches = new List<lanches>();
            }
            lanches NecNachos = new lanches();
            {
                NecNachos.nome = "NecNachos";
                NecNachos.descrição = "Hamburguer com tempero de Nachos para relembrar o gosto mexicano!";
                NecNachos.preçolanche = 11f;
                NecMéxico.lanches.Add(NecNachos);
            }
            lanches NecTaco = new lanches();
            {
                NecTaco.nome = "NecTaco";
                NecTaco.descrição = "Lanche que utiliza os mesmos temperos tradicionais que o taco mexicano";
                NecTaco.preçolanche = 11f;
                NecMéxico.lanches.Add(NecTaco);

            }

           

            static void MostrarLanches(Restaurante restaurante)
            {
                Console.WriteLine("os lanches do restaurante " + restaurante.nome + " São: ");
                Console.WriteLine("");
                foreach (lanches lan in restaurante.lanches)
                {
                    Console.WriteLine("Nome: " + lan.nome);
                    Console.WriteLine("Descrição: " + lan.descrição);
                    Console.WriteLine("Preço do lanche: " + lan.preçolanche + "$");
                    Console.WriteLine("");
                }


            }
            //MÉTODO DE BUSCA DE UM RESTAURANTE ESPECÍFICO
            Console.WriteLine("Voce Deseja Buscar alguma rede específica do Nectronalds ou Todas?");
            buscares = Console.ReadLine();

            if (buscares == "Sim")
            {
                Console.WriteLine("Digite qual o país que você deseja acessar o NecTronalds");
                busca = Console.ReadLine();

                if (busca == "Brasil")
                {
                    MostrarLanches(NecBrasil);
                }
                else if (busca == "Argentina")
                {
                    MostrarLanches(NecArgentina);
                }
                else if (busca == "México")
                {
                    MostrarLanches(NecMéxico);
                }
                else
                {
                    Console.WriteLine("Esse país não existe ou não possui uma unidade do NecTronalds!");
                }
            }
            //MÉTODO DE BUSCA DE TODOS OS RESTAURANTES
            else if (buscares == "Todas")
            {
                MostrarLanches(NecBrasil);
               MostrarLanches(NecMéxico);
                MostrarLanches(NecArgentina);
            }
           
         

        }
        


        

        class Restaurante
        {
           
            public List<lanches> lanches;
            public string nome;


            //METODO DE ADICIONAR E REMOVER
            public void AdicionarLanches(lanches lan)
            {
                this.lanches.Add(lan);
            }
            public void RemoverLanches(lanches lan)
            {
                this.lanches.Remove(lan);
            }


        }
        class lanches
        {
            public string nome;
            public string descrição;
            public float preçolanche;
        }

    }
}
