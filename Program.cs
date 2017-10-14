using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Trabalho_AED
{
    class Program

    {
        static int temp = 0;
        
        static string tempo = "";
        // Menu principal 
        static void Main(string[] args)
        {
            //-----------------------------
            //       MENU
            //-----------------------------

            Console.Title = "Quem Quer Ser Milionário "+"               "+ DateTime.Now.ToString("dd-MM-yyyy");
            char opcao = ' ';
            while (opcao != '5')
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.SetCursorPosition(25, 4);
                Console.WriteLine("-----------------------------");
                Console.SetCursorPosition(25, 5);
                Console.WriteLine("           Menu");
                Console.SetCursorPosition(25, 6);
                Console.WriteLine("-----------------------------");
                Console.SetCursorPosition(25, 7);
                Console.WriteLine("1 - Novo Jogo");
                Console.SetCursorPosition(25, 8);
                Console.WriteLine("2 - Configurações");
                Console.SetCursorPosition(25, 9);
                Console.WriteLine("3 - Rankings");
                Console.SetCursorPosition(25, 10);
                Console.WriteLine("4 - Upload de Questões");
                Console.SetCursorPosition(25, 11);
                Console.WriteLine("5 - Terminar");
                Console.SetCursorPosition(25, 12);
                Console.Write("                Opcção: ");
                Console.SetCursorPosition(25, 20);
                Console.Write("   Created by:");
                Console.SetCursorPosition(25, 21);
                Console.Write(" Paulo Fernandes");
                Console.SetCursorPosition(25, 22);
                Console.Write("  André Gouveia");
                Console.SetCursorPosition(50, 12);
                opcao = Convert.ToChar(Console.ReadLine());
                switch (opcao)
                {
                    case '1':
                        NovoJogo(); // 
                        break;
                    case '2':
                        Configuraçoes(); // 
                        break;
                    case '3':
                        Rankings();  // 
                        break;
                    case '4':
                        UploadQuestoes();//
                        break;
                    case '5': break;
                    default:
                        Console.WriteLine("Opçao invalida");
                        Console.ReadLine();
                        break;
                } // fim do switch
            } // fim do while
        }

        static void NovoJogo()
        {
            char opcao = ' ';
            
            
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.SetCursorPosition(25, 4);
                Console.WriteLine("-----------------------------");
                Console.SetCursorPosition(25, 5);
                Console.WriteLine("           Menu");
                Console.SetCursorPosition(25, 6);
                Console.WriteLine("-----------------------------");
                Console.SetCursorPosition(25, 7);
                Console.WriteLine("1 - Iniciar o Jogo");
                Console.SetCursorPosition(25, 8);
                Console.WriteLine("2 - Voltar Atrás");

                Console.SetCursorPosition(25, 9);
                Console.Write("                Opcção: ");

                Console.SetCursorPosition(25, 20);
                Console.Write("   Created by:");
                Console.SetCursorPosition(25, 21);
                Console.Write(" Paulo Fernandes");
                Console.SetCursorPosition(25, 22);
                Console.Write("  André Gouveia");


            Console.SetCursorPosition(50, 9);
            opcao = Convert.ToChar(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        novoutilizador();
                        break;

                    case '2':                   
                        break;
                    default:
                        Console.WriteLine("Opçao invalida");
                        Console.ReadLine();
                        break;

                }





            
        }     // opçao menu principal novo jogo

        static void Configuraçoes()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("           Menu");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("1 - Tema");
            Console.SetCursorPosition(25, 8);
            Console.WriteLine("2 - Tempo limite para cada jogada ");
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("3 - Escolher o nivel");
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("4 - Escolher nº perguntas");
            Console.SetCursorPosition(25, 11);
            Console.WriteLine("5 - Voltar Atrás");
            Console.SetCursorPosition(25, 12);
            Console.Write("                Opcção: ");

            Console.SetCursorPosition(25, 20);
            Console.Write("   Created by:");
            Console.SetCursorPosition(25, 21);
            Console.Write(" Paulo Fernandes");
            Console.SetCursorPosition(25, 22);
            Console.Write("  André Gouveia");

            char opcao = ' ';
            Console.SetCursorPosition(50, 12);
            opcao = Convert.ToChar(Console.ReadLine());
            switch (opcao)
            {
                case '1':
                    tema(); // escolher o tema das perguntas
                    break;

                case '2':
                    tlcj(); // escolher o tempo limite para cada jogada
                    break;

                case '3':
                    nivel(); // escolher o nivel
                    break;

                case '4':
                    np(); // escolher nº perguntas
                    break;
                case '5':
                    
                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    Console.ReadLine();
                    break;

            }



        } // opçao menu principal configuraçoes

        static void Rankings()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("           Menu");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("1 - Top 5");
            Console.SetCursorPosition(25, 8);
            Console.WriteLine("2 - Geral ");
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("3 - Voltar Atrás ");
            Console.SetCursorPosition(25, 10);
            Console.Write("                Opcção: ");

            Console.SetCursorPosition(25, 20);
            Console.Write("   Created by:");
            Console.SetCursorPosition(25, 21);
            Console.Write(" Paulo Fernandes");
            Console.SetCursorPosition(25, 22);
            Console.Write("  André Gouveia");


            char opcao = ' ';
            Console.SetCursorPosition(50, 10);
            opcao = Convert.ToChar(Console.ReadLine());

            switch (opcao)
            {
                case '1':
                    top5();
                    break;

                case '2':
                    geral();
                    break;
                case '3':
                    
                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    Console.ReadLine();
                    break;

            }




        } // opçao menu principal rankings

        static void UploadQuestoes()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Indique a Dificuladade:");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("1-Fácil:");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("2-Médio:");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("3-Dificil:");
            Console.SetCursorPosition(25, 8);
            Console.Write("                Opcção: ");

            Console.SetCursorPosition(25, 20);
            Console.Write("   Created by:");
            Console.SetCursorPosition(25, 21);
            Console.Write(" Paulo Fernandes");
            Console.SetCursorPosition(25, 22);
            Console.Write("  André Gouveia");
            Console.SetCursorPosition(50, 8);
            string dificuldade = Console.ReadLine();

            Console.Clear();
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Indique o Tema:");  // perguntar ao utilizador qual é o tema da pergunta que quer inserir
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("1 - Geral");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("2 - Desporto");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("3 - Música");
            Console.SetCursorPosition(25, 8);
            Console.Write("                Opcção: ");

            Console.SetCursorPosition(25, 20);
            Console.Write("   Created by:");
            Console.SetCursorPosition(25, 21);
            Console.Write(" Paulo Fernandes");
            Console.SetCursorPosition(25, 22);
            Console.Write("  André Gouveia");
            Console.SetCursorPosition(50, 8);
            string tema = Console.ReadLine();
            string dificuldade1 = "";
            string tema1 = "";

            if (tema == "1")
            {
                tema1 = "Geral";

            }
            else if (tema == "2")
            {
                tema1 = "Desporto";
            }
            else if (tema == "3")
            {
                tema1 = "Música";
            }

            if (dificuldade == "1")
            {
                dificuldade1 = "Fácil";

            }
            else if (dificuldade == "2")
            {
                dificuldade1 = "Médio";
            }
            else if (dificuldade == "3")
            {
                dificuldade1 = "Díficil";
            }


            Console.Clear();


            string pastadificulade = AppDomain.CurrentDomain.BaseDirectory+dificuldade1;
            string ficheiro = pastadificulade + @"\"+  tema1 + ".txt";

            if (File.Exists(ficheiro) == true)     // verificar se o tema existe
            {
                string linha = "";
                string pergunta, resposta1, resposta2, resposta3, resposta4, respostacerta;

                Console.SetCursorPosition(0, 2);
                Console.Write("Indique a Pergunta:");  // perguntar qual é a pergunta
                Console.SetCursorPosition(21, 2);
                pergunta = Console.ReadLine();

                bool s = false;
                StreamReader sr;
                StreamWriter sw;

                if (File.Exists(ficheiro))   // verificar se a pergunta já existe
                {
                    sr = File.OpenText(ficheiro);

                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] pergunta2 = new string[1];
                        pergunta2 = linha.Split(';');
                        if (pergunta2[0] == pergunta)
                        {

                            Console.Write("A pergunta já Existe!");
                            s = true;
                        }

                    }

                    sr.Close();
                }



                if (s == false)
                {

                    if (File.Exists(ficheiro))     // se a pergunta nao existe, perguntar as respostas e guardar as respostas no ficheiro

                    {


                        Console.SetCursorPosition(0, 4);
                        Console.Write("Indique a Resposta A:");
                        Console.SetCursorPosition(23, 4);
                        resposta1 = Console.ReadLine();

                        Console.SetCursorPosition(0, 6);
                        Console.Write("Indique a Resposta B:");
                        Console.SetCursorPosition(23, 6);
                        resposta2 = Console.ReadLine();

                        Console.SetCursorPosition(0, 8);
                        Console.Write("Indique a Resposta C:");
                        Console.SetCursorPosition(23, 8);
                        resposta3 = Console.ReadLine();

                        Console.SetCursorPosition(0, 10);
                        Console.Write("Indique a Resposta D:");
                        Console.SetCursorPosition(23, 10);
                        resposta4 = Console.ReadLine();

                        Console.SetCursorPosition(0, 12);
                        Console.Write("Indique a Alinea da Resposta Certa:");
                        Console.SetCursorPosition(27, 12);
                        respostacerta = Console.ReadLine();


                        linha = pergunta + ";" + resposta1 + ";" + resposta2 + ";" + resposta3 + ";" + resposta4 + ";" + respostacerta;

                    }
                    sw = File.AppendText(ficheiro);

                    sw.WriteLine(linha);
                    sw.Close();
                }





            }
            else
            {
                Console.Write("O Ficheiro não existe!!!");
            }

            Console.ReadLine();
        } // opçao menu novo jogo  uploadquestoes


        // sub menus

        static void top5() // opcçao top 5 da opçao principal rankigs
        {
            string ranking = @"ranking.txt";
            Console.Clear();

            string[] ran1 = File.ReadAllLines(ranking);
            int lin = 5;
            bool Ra = false;
            int compri =ran1.Length;

            if (compri<5)
            {
                for (int i = 0; i < ran1.Length; i++)
                {



                    string[] dados = new string[4];
                    dados = ran1[i].Split(';');

                    Console.SetCursorPosition(0, 0);
                    Console.Write("------------------------------------------------------------------");
                    Console.SetCursorPosition(0, 1);
                    Console.Write(" Código          Nome           Vezes Jogadas          Pontuação");
                    Console.SetCursorPosition(0, 2);
                    Console.Write("------------------------------------------------------------------");
                    Console.SetCursorPosition(3, lin);
                    Console.Write(dados[0]);
                    Console.SetCursorPosition(17, lin);
                    Console.Write(dados[1]);
                    Console.SetCursorPosition(37, lin);
                    Console.Write(dados[2]);
                    Console.SetCursorPosition(57, lin);
                    Console.Write(dados[3]);
                    lin++;
                }
            }
            else if ( compri>5)

            {
                for (int i = 0; i < 5; i++)
                {



                    string[] dados = new string[4];
                    dados = ran1[i].Split(';');

                    Console.SetCursorPosition(0, 0);
                    Console.Write("------------------------------------------------------------------");
                    Console.SetCursorPosition(0, 1);
                    Console.Write(" Código          Nome           Vezes Jogadas          Pontuação");
                    Console.SetCursorPosition(0, 2);
                    Console.Write("------------------------------------------------------------------");
                    Console.SetCursorPosition(3, lin);
                    Console.Write(dados[0]);
                    Console.SetCursorPosition(17, lin);
                    Console.Write(dados[1]);
                    Console.SetCursorPosition(37, lin);
                    Console.Write(dados[2]);
                    Console.SetCursorPosition(57, lin);
                    Console.Write(dados[3]);
                    lin++;
                }
            }
            


            Console.ReadLine();
        }

        static void geral()  // ranking geral
        {
            string ranking = @"ranking.txt";
            Console.Clear();

            string[] ran1 = File.ReadAllLines(ranking);
            int lin = 5;
            for (int i =0; i<ran1.Length;i++)
            {
                string[] dados = new string[4];
                dados = ran1[i].Split(';');
                
                
                Console.SetCursorPosition(0, 0);
                Console.Write("------------------------------------------------------------------");
                Console.SetCursorPosition(0, 1);
                Console.Write(" Código          Nome           Vezes Jogadas          Pontuação");
                Console.SetCursorPosition(0, 2);
                Console.Write("------------------------------------------------------------------");
                Console.SetCursorPosition(3, lin);
                Console.Write(dados[0]);
                Console.SetCursorPosition(17, lin);
                Console.Write(dados[1]);
                Console.SetCursorPosition(37, lin);
                Console.Write(dados[2]);
                Console.SetCursorPosition(57, lin);
                Console.Write(dados[3]);
                lin++;
            }


            Console.ReadLine();


        }

        static void tema() // opçao escolha do tema
        {

            string tema = "";
            bool t = false;
            while (t != true)
            {
                Console.Clear();
                Console.WriteLine("Indique o tema que deseja para jogar: ");
                Console.WriteLine("1 - Geral");
                Console.WriteLine("2 - Desporto");
                Console.WriteLine("3 - Música");
                tema = Console.ReadLine();

                if (tema=="1" || tema == "2"|| tema == "3")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
            }
            string tema1 = "";

            if (tema=="1")
            {
                tema1 = "Geral";

            }
            else if(tema == "2")
            {
                tema1 = "Desporto";
            } 
            else if (tema == "3")
            {
                tema1 = "Música";
            }

            

            StreamReader sr;
            StreamWriter sw;
            string ficheiro = @"setup.txt";
            string linha = "";
            string ficheiro2 = @"setup2";
            sw = File.AppendText(ficheiro2);

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] setup = new string[2];
                    setup = linha.Split(';');

                    if (setup[1] == tema1 && setup[0] == "tema")
                    {
                        Console.WriteLine(" O tema  escolhido foi:{0}", tema1);
                        sw.WriteLine(linha);
                    }

                    else if (setup[1] != tema1 && setup[0] == "tema")
                    {
                        Console.WriteLine("O tema escolhido foi:{0} ", tema1);
                        sw.WriteLine(setup[0] + ";" + tema1);
                    }
                    else if (setup[1] != tema1 && setup[0] != "tema")
                    {

                        sw.WriteLine(linha);
                    }
                    else if (setup[1] == tema1 && setup[0] != "tema")
                    {
                        sw.WriteLine(linha);
                    }




                }
                sr.Close();
                sw.Close();

                File.Delete(@"setup.txt");

                File.Move(ficheiro2, @"setup.txt");


            }


            Console.ReadLine();


        }

        // opçao escolha tempo limite de cada jogada
        static void tlcj()
        {
            string tlcj = "";
            bool t = false;
            while (t != true)
            {
                Console.WriteLine("Indique o tempo limite de cada jogada que deseja: ");
                Console.WriteLine("1 - 15 Segundos");
                Console.WriteLine("2 - 20 Segundos");
                Console.WriteLine("3 - 30 Segundos");
                tlcj = Console.ReadLine();

                if (tlcj == "1" || tlcj == "2" || tlcj == "3")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
            }

            string tlcj1 = "";

            if (tlcj == "1")
            {
                tlcj1 = "15";

            }
            else if (tlcj == "2")
            {
                tlcj1 = "20";
            }
            else if (tlcj == "3")
            {
                tlcj1 = "30";
            }








        
        StreamReader sr;
            StreamWriter sw;
            string ficheiro = @"setup.txt";
            string linha = "";
            string ficheiro2 = @"setup2";
            sw = File.AppendText(ficheiro2);

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] setup = new string[2];
                    setup = linha.Split(';');

                    if (setup[1] == tlcj1 && setup[0] == "tempo")
                    {
                        Console.WriteLine(" O tempo limite escolhido para cada resposta foi:{0} segundos", tlcj1);
                        sw.WriteLine(linha);
                    }

                    else if (setup[1] != tlcj1 && setup[0] == "tempo")
                    {
                        Console.WriteLine("O tempo limite escolhido para cada resposta foi:{0} segundos ", tlcj1);
                        sw.WriteLine(setup[0] + ";" + tlcj1);
                    }
                    else if (setup[1] != tlcj1 && setup[0] != "tempo")
                    {

                        sw.WriteLine(linha);
                    }
                    else if (setup[1] == tlcj1 && setup[0] != "tempo")
                    {
                        sw.WriteLine(linha);
                    }




                }
                sr.Close();
                sw.Close();

                File.Delete(@"setup.txt");

                File.Move(ficheiro2, @"setup.txt");


            }


            Console.ReadLine();


        }

        // escolha do nivel 
        static void nivel()
        {
            string nivel = "";
                      
            bool t = false;
            while (t != true)
            {
                Console.WriteLine("Indique o nivel de dificuldade que deseja jogar: ");
                Console.WriteLine("1 - Fácil");
                Console.WriteLine("2 - Médio");
                Console.WriteLine("3 - Díficil");
                nivel = Console.ReadLine();


                if (nivel == "1" || nivel == "2" || nivel == "3")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
            }

            string nivel1 = "";

            if (nivel == "1")
            {
                nivel1 = "Fácil";

            }
            else if (nivel == "2")
            {
                nivel1 = "Médio";
            }
            else if (nivel == "3")
            {
                nivel1 = "Díficil";
            }
                                             
            

            StreamReader sr;
            StreamWriter sw;
            string ficheiro = @"setup.txt";
            string linha = "";
            string ficheiro2 = @"setup2";
            sw = File.AppendText(ficheiro2);

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] setup = new string[2];
                    setup = linha.Split(';');

                    if (setup[1] == nivel1 && setup[0] == "dificuldade")
                    {
                        Console.WriteLine(" O nivel de dificuldade escolhido foi:{0}", nivel1);
                        sw.WriteLine(linha);
                    }

                    else if (setup[1] != nivel1 && setup[0] == "dificuldade")
                    {
                        Console.WriteLine("O nivel de dificuldade escolhido foi:{0}  ", nivel1);
                        sw.WriteLine(setup[0] + ";" + nivel1);
                    }
                    else if (setup[1] != nivel1 && setup[0] != "dificuldade")
                    {

                        sw.WriteLine(linha);
                    }
                    else if (setup[1] == nivel1 && setup[0] != "dificuldade")
                    {
                        sw.WriteLine(linha);
                    }




                }
                sr.Close();
                sw.Close();

                File.Delete(@"setup.txt");

                File.Move(ficheiro2, @"setup.txt");


            }


            Console.ReadLine();



        }

        // escolha nº perguntas
        static void np()
        {
            string np="";
            
            


            bool t = false;
            while (t != true)
            {
                Console.WriteLine("Indique o numero de perguntas que deseja: ");
                Console.WriteLine("1 - 5 Perguntas");
                Console.WriteLine("2 - 10 Perguntas");
                Console.WriteLine("3 - 15 Perguntas");
                np = Console.ReadLine();


                if (np == "1" || np == "2" || np == "3")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
            }

            string np1 = "";

            if (np == "1")
            {
                np1 = "5";

            }
            else if (np == "2")
            {
                np1 = "10";
            }
            else if (np == "3")
            {
                np1 = "15";
            }








            StreamReader sr;
            StreamWriter sw;
            string ficheiro = @"setup.txt";
            string linha = "";
            string ficheiro2 = @"setup2";
            sw = File.AppendText(ficheiro2);

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] setup = new string[2];
                    setup = linha.Split(';');

                    if (setup[1] == np1 && setup[0] == "np")
                    {
                        Console.WriteLine(" O numero de perguntas escolhidas foi {0}", np1);
                        sw.WriteLine(linha);
                    }

                    else if (setup[1] != np1 && setup[0] == "np")
                    {
                        Console.WriteLine(" O numero de perguntas escolhidas foi {0}", np1);
                        sw.WriteLine(setup[0] + ";" + np1);
                    }
                    else if (setup[1] != np1 && setup[0] != "np")
                    {

                        sw.WriteLine(linha);
                    }
                    else if (setup[1] == np1 && setup[0] != "np")
                    {
                        sw.WriteLine(linha);
                    }




                }
                sr.Close();
                sw.Close();

                File.Delete(@"setup.txt");

                File.Move(ficheiro2, @"setup.txt");


            }

            Console.ReadLine();
        }



        // novo utilizador
        static void novoutilizador()
        {
             bool R = true;
            string respostacerta = "";
             string resposta = "";
            int pontuaçao = 0;
            int vezesjogadas = 0;
            int cont1 = 0;
            string ranking = @"ranking.txt";
            String nomeutilizador = "";
            bool nome = false;
            while (nome == false)
            {
                Console.Clear();

                Console.Write("Nome de Utilizador:");
                nomeutilizador = Console.ReadLine();
                
                
                StreamReader sr3;
                
                if (File.Exists(ranking))
                {
                    sr3 = File.OpenText(ranking);
                    string ran = "";

                    while ((ran = sr3.ReadLine()) != null)
                    {

                        string[] ran1 = new string[4];
                        ran1 = ran.Split(';');

                        string nome1= ran1[1];
                         vezesjogadas = Convert.ToInt16( ran1[2]);
                        pontuaçao = Convert.ToInt16(ran1[3]);



                        if (ran1[1] == nomeutilizador)
                        {
                            cont1++;
                            
                        }
                                               
                    }

                    sr3.Close();

                    if (cont1 == 0)
                    {
                        vezesjogadas = 1;
                        pontuaçao = 0;
                        nome = true;
                    }
                    else if  (cont1 == 1)
                    {
                        Console.WriteLine(" Utilizador já utilizado");
                        Console.WriteLine(" Deseja Utilizar?");
                        Console.WriteLine(" 1-Sim");
                        Console.WriteLine(" 2-Nao");
                        string res = Console.ReadLine();
                        
                        if ( res== "1")
                        {
                            vezesjogadas = vezesjogadas + 1;
                            
                            nome = true;
                        }
                        else
                        {
                            nome = false;
                        }

                        
                    }

                }
            }

            // ir buscar as configuraçoes escolhidas na opção 2
            string setup = @"setup.txt";
            
            string np = "";
            string dificuldade = "";
            string tema = "";

            StreamReader sr4 = File.OpenText(setup);
            string linha4 = "";

            while ((linha4 = sr4.ReadLine()) != null)
            {
                string[] setup2 = new string[2];
                setup2 = linha4.Split(';');

                if (setup2[0] == "tempo")
                {
                    tempo = setup2[1];
                }
                else if (setup2[0] == "np")
                {
                    np = setup2[1];
                }
                else if (setup2[0] == "dificuldade")
                {
                    dificuldade = setup2[1];
                }
                else if (setup2[0] == "tema")
                {
                    tema = setup2[1];
                }




            }
            sr4.Close();


            string pastadificulade = AppDomain.CurrentDomain.BaseDirectory + dificuldade;
            string ficheiro = pastadificulade + @"\" + tema + ".txt";

           
            
            int n = 0;
            

            
            // ler as perguntas todas para um array
            string []pergunta =File.ReadAllLines(ficheiro);

            // i nº de perguntas
            // ir buscar uma pergunta aleatoria ao ficheiro de texto
            int posicao = 0;
            int numper = 1;
            int[] aleatorio1 = new int[Convert.ToInt16(np)];

            while ((n < Convert.ToInt16(np)) && (R == true))
            {
                Console.Clear();
               
                
                // quantas linhas tem o ficheiro
                int cont2 = pergunta.Length;
                
                
                                
                int aleatorio=0;
                Random rdn = new Random();

                // gerar numeros aleatorios sem repetição


                
                int pos = -2;
               

                while (pos != -1)
                {
                    aleatorio = rdn.Next(1, cont2);
                    pos = Array.IndexOf(aleatorio1, aleatorio);
                    
                    
                }
                aleatorio1[posicao] = aleatorio;
                posicao++;



                string perguntas = "";
                string resposta1 = "";
                string resposta2 = "";
                string resposta3 = "";
                string resposta4 = "";
                
                for (int i=0;i<pergunta.Length;i++)
                {
                    

                    if ( i == aleatorio)
                    {
                        string[] array3 = new string[5];
                        array3 = pergunta[i].Split(';');
                        perguntas = array3[0];
                         resposta1 = array3[1];
                        resposta2 = array3[2];
                         resposta3 = array3[3];
                         resposta4 = array3[4];
                         respostacerta = array3[5];
                        

                    }
                }
                
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.Write("Pergunta Número {0} de {1} ", numper, np);

                Console.SetCursorPosition(0, 6);
                Console.Write(perguntas);
                Console.SetCursorPosition(0, 8);
                Console.Write("A-{0}",resposta1);
                Console.SetCursorPosition(35, 8);
                Console.Write("B-{0}", resposta2);
                Console.SetCursorPosition(0, 10);
                Console.Write("C-{0}", resposta3);
                Console.SetCursorPosition(35, 10);
                Console.Write("D-{0}", resposta4);
                Console.SetCursorPosition(0, 12);
                Console.Write("Indique a Sua resposta: ");
                Console.SetCursorPosition(25, 20);
                Console.Write("   Created by:");
                Console.SetCursorPosition(25, 21);
                Console.Write(" Paulo Fernandes");
                Console.SetCursorPosition(25, 22);
                Console.Write("  André Gouveia");


                // Define um callback para um Timer
                TimerCallback callback = new TimerCallback(Tick);

                //  Inicia uma instância do Timer com a periodicidade de 1 segundo
                Timer stateTimer = new Timer(callback, null, 0, 1000);

                Console.SetCursorPosition(24, 12);
                resposta = Console.ReadLine();

                stateTimer.Dispose();

                if ( resposta==respostacerta && temp < Convert.ToInt16(tempo))
                {
                    
                    Console.SetCursorPosition(0, 13);
                    Console.Write(" Resposta Certa!!! ");
                    temp = 0;
                    n++;
                    numper++;
                    
                    Console.ReadLine();
                    Console.Clear();
                }
                else 
                {
                    temp = 0;
                    R = false;
                    Console.Clear();
                }


                

            }

            // pontuaçoes

            if ((n == Convert.ToInt16(np)) && (R == true))
            {
                if (dificuldade=="Fácil")
                {
                  pontuaçao =pontuaçao+ (1 * 10); 
                }
                else if (dificuldade == "Médio")
                {
                    pontuaçao = pontuaçao + (1 * 20);
                }
                else if (dificuldade == "Díficil")
                {
                    pontuaçao = pontuaçao + (1 * 30);
                }
                Console.SetCursorPosition(20, 5);
                Console.Write("Parabéns !!! Ganhou o Jogo !!!");
            }
            else if ( R==false)
            {
                if (dificuldade == "Fácil")
                {
                    pontuaçao =pontuaçao- (30 / 1);
                }
                else if (dificuldade == "Médio")
                {
                    pontuaçao = pontuaçao -(30 / 2);
                }
                else if (dificuldade == "Díficil")
                {
                    pontuaçao = pontuaçao - (30 / 3); 
                }
                Console.SetCursorPosition(20, 5);
                Console.Write(" Perdeu o jogo ! ! ! ");
            }

            if (pontuaçao <=0)
            {
                pontuaçao = 0;
            }
            Console.SetCursorPosition(20, 6);
            Console.Write(" A Sua pontuação é:{0} ",pontuaçao);

            // abrir o ficheiro de ranking para para guardar a pontuçao 



            StreamWriter sw;
            StreamReader sr2;
            if (File.Exists(ranking))
            {
                sw = File.AppendText(ranking);
            }

            else
            {
                sw = File.CreateText(ranking);
            }

            int codigo =0001;

            string linha = nomeutilizador + ";"+(vezesjogadas)+";" + pontuaçao.ToString();
            
            sw.Close();


            // ordenar o ficheiro de ranking
            int cnt = 0;
            string ranking2 = @"ranking2.txt";

            StreamWriter sw2;
            sw2 = File.AppendText(ranking2);
            string[] array = new string[4];

            if (File.Exists(ranking))
            {
                sr2 = File.OpenText(ranking);


                string linha3 = "";

                while ((linha3 = sr2.ReadLine()) != null)

                {
                    array = linha3.Split(';');

                    


                    if (cnt < 1)
                    {
                        if (pontuaçao >= Convert.ToInt16(array[3]))
                        {
                            sw2.WriteLine(codigo+";" + linha);
                            codigo++;
                            sw2.WriteLine(codigo + ";" + array[1] + ";" + array[2]+ ";" + array[3]);
                            cnt++;
                            codigo++;
                        }
                        else
                        {
                            sw2.WriteLine(codigo + ";" + array[1] + ";" + array[2] + ";" + array[3]);
                            codigo++;
                        }
                    }

                    else
                    {
                        sw2.WriteLine(codigo + ";" + array[1] + ";" + array[2] + ";" + array[3]);
                        codigo++;
                    }


                }
                sw2.Close();
                sr2.Close();


            }
           




            File.Delete(@"ranking.txt");

            File.Move(ranking2, @"ranking.txt");

            if (cont1 != 0)
            {
                int codigo1 = 1;
                string[] rank = File.ReadAllLines(ranking);
                StreamWriter sw3 = File.CreateText(ranking);

                for (int i = 0; i < rank.Length; i++)
                {
                    string[] array2 = new string[4];
                    array2 = rank[i].Split(';');

                    

                    if (array2[1] == nomeutilizador && vezesjogadas == Convert.ToInt16 (array2[2]) || array2[1] != nomeutilizador)
                        {
                            sw3.WriteLine(codigo1 + ";" + array2[1] + ";" + array2[2] + ";" + array2[3]);
                            codigo1++;
                            

                        }
                   

                    
                }
                sw3.Close();
            }
           
            Console.ReadLine();



        }



        

        

        static  void Tick(Object obj)
        {


            

            //variável que acumula o nº de segundos
            temp++;

                       
            //posicionamento do cursor para escrita de um cronómetro
            Console.SetCursorPosition(45, 0);

            //Escrita do cronómetro
            Console.Write("Tempo:{0}",temp);

            //reposicionamento do cursor para leitura de símbolo

            Console.SetCursorPosition(24,12);


            if (temp>Convert.ToInt16(tempo))
            {
                Console.SetCursorPosition(0, 13);

                Console.Write("Ultrapassou o tempo !!!");
                
            }

            
        }
    }
}
