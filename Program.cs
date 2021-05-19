using System;

namespace POO_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            string status_celular;
            string opcoes;
            string numero_ligacao;
            string contato;
            string msg;
            bool check = false;
            bool check2 = false;



            Celular celular1 = new Celular();
            celular1.cor = "Ciano";
            celular1.modelo = "Moto G9";
            celular1.tamanho = "5.5 Polegadas";

            do
            {
                if (celular1.ligar() == true)
                {
                    Console.WriteLine($@"
O celular está desligado!:
Pressione 1 para ligar                    
                    ");
                    status_celular = Console.ReadLine();

                    while (check == false)
                    {
                        if (status_celular == "1")
                        {
                            celular1.ligar();
                            Console.WriteLine($@"
Android inicializado!
1- Ligar
2- Enviar Mensagem
3- Mostrar Informações
0- Desligar
                     ");
                            opcoes = Console.ReadLine();
                            switch (opcoes)
                            {
                                case "1":
                                    Console.WriteLine("Digite um número para ligar");
                                    numero_ligacao = Console.ReadLine();
                                    Console.WriteLine(celular1.ligacao());
                                    break;
                                case "2":
                                    Console.WriteLine("Digite para quem vai ser a mensagem");
                                    contato = Console.ReadLine();
                                    Console.WriteLine("Digite sua mensagem: ");
                                    msg = Console.ReadLine();
                                    Console.WriteLine(celular1.mensagem());
                                    Console.WriteLine($@"Mensagem enviada com sucesso para {contato}");
                                    break;
                                case "3":
                                    Console.WriteLine($"COR: {celular1.cor}");
                                    Console.WriteLine($"TAMANHO: {celular1.tamanho}");
                                    Console.WriteLine($"MODELO: {celular1.modelo}");
                                    break;
                                case "0":
                                    check = true;
                                    check2 = false;
                                    break;
                                default:
                                    break;
                            }
                        }

                    }
                }
            } while (check2 == true);
        }
    }
}
