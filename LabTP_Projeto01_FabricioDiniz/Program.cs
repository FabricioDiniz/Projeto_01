using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP_Projeto01_FabricioDiniz
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o número correspondente à opção desejada:\n");
                Console.WriteLine("1 - Uber (controle de custos)");
                Console.WriteLine("2 - Futebol (resultado)");
                Console.WriteLine("3 - Triângulo (classificação)");
                Console.WriteLine("4 - Estatística (gênero)");
                Console.WriteLine("0 - Sair\n");
                op = EntradasInt();
                Console.Clear();

                switch (op)
                {
                    case 1:

                        const double gasolina = 3.70;
                        double hodometroInicio = 0, hodometroFim = 0, valorRecebido = 0, mediaKmporLitro = 0, lucroLiquido = 0, litrosGastos = 0;

                        do
                        {
                            Console.WriteLine("*****Calcular gastos e lucro diário do motorista do Uber*****\n");
                            Console.WriteLine("Informe a marcação do Hodômetro (Km) no inicio do dia:\n");
                            hodometroInicio = EntradasDouble();
                            Console.WriteLine("\nInforme a marcação do Hodômetro (Km) no fim do dia:\n");
                            hodometroFim = EntradasDouble();
                            Console.WriteLine("\nInforme quantos litros foram gastos:\n");
                            litrosGastos = EntradasDouble();
                            Console.WriteLine("\nInforme o valor total recebido dos passageiros:\n");
                            valorRecebido = EntradasDouble();

                            //Verifica entradas menores ou iguais à 0:
                        } while (hodometroInicio <= 0 || hodometroFim <= 0 || litrosGastos <= 0 || valorRecebido <= 0);

                        //Calcula média de Km/l gastos no dia:
                        mediaKmporLitro = (hodometroFim - hodometroInicio)/litrosGastos;
                        //Calcula lucro liquido do dia:
                        lucroLiquido = valorRecebido - (litrosGastos * gasolina);

                        Console.Clear();
                        Console.WriteLine("A sua média de consumo no dia é de {0}Km/l.\n", mediaKmporLitro);
                        Console.WriteLine("O seu lucro liquido do dia foi de R${0}.\n", lucroLiquido);

                        VoltarMenu();
                        break;

                    case 2:

                        int golsa = 0, golsc = 0, golsdif = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informar quantos gols Atlético e Cruzeiro marcaram na partida para saber:");
                            Console.WriteLine("*****Quem foi o vencedor*****");
                            Console.WriteLine("*****Qual a diferença de gols*****");
                            Console.WriteLine("*****E se esse valor é par ou ímpar*****\n");

                            Console.WriteLine("\nQuantos gols foram marcados pelo Atlético?\n");
                            golsa = EntradasInt();                            
                            Console.WriteLine("\nQuantos gols foram marcados pelo Cruzeiro?\n");
                            golsc = EntradasInt();

                            //Verifica entradas menores que 0:
                        } while (golsa < 0 || golsc < 0);

                        //Verifica quem marcou mais gols:
                        if(golsa > golsc)
                        {
                            Console.Clear();
                            //Calcula quantos gols à mais o Atlético marcou:
                            golsdif = golsa - golsc; 
                            Console.WriteLine("O vencedor foi o Atlético, com uma diferença de {0} gol(s).", golsdif);
                        }
                        else if (golsc > golsa)
                        {
                            Console.Clear();
                            //Calcula quantos gols à mais o Cruzeiro marcou:
                            golsdif = golsc - golsa;
                            Console.WriteLine("O vencedor foi o Cruzeiro, com uma diferença de {0} gol(s).", golsdif);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("A partida ficou empatada.\n");
                        }
                        //Caso o jogo não tenha empatado...
                        if (golsdif != 0)
                        {
                            //Verifica se a diferença de gols é par ou ímpar:
                            if (golsdif % 2 == 0)
                            {
                                Console.WriteLine("Essa diferença é par.\n");
                            }
                            else
                            {
                                Console.WriteLine("Essa diferença é ímpar.\n");
                            }
                        }
                        VoltarMenu();
                        break;

                    case 3:

                        int angulo1 = 0, angulo2 = 0, angulo3 = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informar 3 ângulos de um triângulo para definir sua classificação:");
                            Console.WriteLine("*****Retângulo: possui um ângulo reto (igual a 90º)*****");
                            Console.WriteLine("*****Obtusângulo: possui um ângulo obtuso (maior que 90º)*****");
                            Console.WriteLine("*****Acutângulo: possui três ângulos agudos (menor que 90º)*****");
                            Console.WriteLine("\nObs.: lembre-se que a soma dos ângulos não pode ser diferente que 180,");
                            Console.WriteLine("nesse caso será necessário reinserir os ângulos.\n");

                            Console.WriteLine("\nInforma um valor (graus) para o primeiro ângulo:\n");
                            angulo1 = EntradasInt();
                            Console.WriteLine("\nInforma um valor (graus) para o segundo ângulo:\n");
                            angulo2 = EntradasInt();
                            Console.WriteLine("\nInforma um valor (graus) para o terceiro ângulo:\n");
                            angulo3 = EntradasInt();

                            //Verifica se a soma dos ângulos é igual a 180º:
                        } while (angulo1 + angulo2 + angulo3 != 180);

                        Console.Clear();
                        //Verifica os ângulos e determina a classificação do triângulo:
                        if(angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
                        {
                            Console.WriteLine("\nO triângulo é retângulo.");
                        }
                        else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
                        {
                            Console.WriteLine("\nO triângulo é obtusângulo.");
                        }
                        else
                        {
                            Console.WriteLine("\nO triângulo é acutângulo.");
                        }
                        VoltarMenu();
                        break;

                    case 4:

                        double altura = 0, alturaMenor = 0, alturaMaior = 0, alturaMedia = 0, auxMedia = 0;
                        int sexom = 0, sexof = 0;
                        string sexo;
                        for (int i = 0; i < 10; i++)
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Insira o sexo (M ou F) e a altura(m) de 10 pessoas para:");
                                Console.WriteLine("*****Saber qual a menor e maior altura*****");
                                Console.WriteLine("*****Qual a média de altura das mulheres*****");
                                Console.WriteLine("*****E a quantidade de homens*****\n");
                                
                                Console.WriteLine("\nInforme a altura em metros (ex.: 1,83) da pessoa {0}:\n", (i + 1));
                                altura = EntradasDouble();

                                //Se estiver na primeira execução alturaMenor e alturaMaior recebem altura inserida pelo usuário:
                                if (i == 0)
                                {
                                    alturaMaior = altura;
                                    alturaMenor = altura;
                                }
                                //Da segunda execução em diante...
                                else
                                {
                                    //Verifica se a altura inserida é menor que a alturaMenor:
                                    if(altura < alturaMenor)
                                    {
                                        alturaMenor = altura;
                                    }
                                    //Ou se a altura inserida é maior que a alturaMaior:
                                    else if (altura > alturaMaior)
                                    {
                                        alturaMaior = altura;
                                    }
                                }
                                Console.WriteLine("\nInforme o sexo da pessoa {0}:\n", (i + 1));
                                sexo = Console.ReadLine();
                                //Verifica se é homem e adiciona à quantidade:
                                if (sexo.Equals("M") || sexo.Equals("m"))
                                {
                                    sexom++;
                                }
                                //Verifica se é mulher, adiciona à quantidade e soma as alturas:
                                else if (sexo.Equals("F") || sexo.Equals("f"))
                                {
                                    sexof++;
                                    auxMedia = auxMedia + altura;
                                }
                            //Verifica se foi inserido um valor diferente do solicitado:
                            } while ((sexo != "M" && sexo != "m" && sexo != "F" && sexo != "f") || (altura<=0));
                        }
                        //Altura média das mulheres será igual a soma de todas as alturas (mulher) divido pela quantidade (mulher):
                        alturaMedia = auxMedia / sexof;
                        Console.Clear();
                        Console.WriteLine("\nMenor altura: {0}m e maior altura: {1}m", alturaMenor, alturaMaior);
                        Console.WriteLine("\nA média de altura das mulheres é: {0}m", alturaMedia);
                        Console.WriteLine("\nQuantidade de homens: {0}", sexom);

                        VoltarMenu();
                        break;

                    case 0:

                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Digite uma opção válida.\n");
                        VoltarMenu();
                        break;
                }
            } while (op >= 0 && op <= 4);

            Console.ReadKey(true);
        }
        //Método para verificar entradas do tipo double
        public static double EntradasDouble()
        {
            bool verificarEntrada;
            double entrada = 0;

            do
            {
                try
                {
                    entrada = double.Parse(Console.ReadLine());
                    verificarEntrada = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nEntrada inválida! Digite novamente.\n");
                    verificarEntrada = false;
                }
            } while (verificarEntrada == false);

            return entrada;
        }
        //Método para verificar entradas do tipo int
        public static int EntradasInt()
        {
            bool verificarEntrada;
            int entrada = 0;

            do
            {
                try
                {
                    entrada = int.Parse(Console.ReadLine());
                    verificarEntrada = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nEntrada inválida! Digite novamente.\n");
                    verificarEntrada = false;
                }
            } while (verificarEntrada == false);

            return entrada;
        }
        //Método para voltar ao menu ou fechar aplicação
        public static void VoltarMenu()
        {
            string entrada = "";
            do
            {
                Console.WriteLine("\nDigite 'S' para sair ou 'M' para ir ao menu.\n");
                entrada = Console.ReadLine();
            } while (entrada != "S" && entrada != "s" && entrada != "M" && entrada !="m");

            if(entrada.Equals("S") || entrada.Equals("s"))
            {
                Environment.Exit(0);
            }

            return;
        }
    }
}