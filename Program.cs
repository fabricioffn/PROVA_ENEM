using System;
using System.Threading;


namespace prova_enem
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            string nomeEscola;
            string resposta;
            int totalQuestoes;

            string questaoPortugues = @"
    O léxico e a cultura
    Potencialmente, todas as línguas de todos os tempos podem candidatar-se a expressar qualquer conteúdo. A pesquisa linguística do século XX demonstrou que não há diferença qualitativa entre os idiomas do mundo –
    ou seja, não há idiomas gramaticalmente mais primitivos ou mais desenvolvidos. Entretanto, para que possa ser efetvamente utilizada, essa igualdade potencial precisa realizar-se na prática histórica do idioma, o que nem sempre acontece.
    Teoricamente, uma língua com pouca tradição escrita (como as línguas indígenas brasileiras) ou uma língua já extinta (como o latim ou o grego clássicos) podem ser empregadas para falar sobre qualquer assunto, como, digamos, física quântica ou biologia molecular.
    Na prática, contudo, não é possível, de uma hora para outra, expressar tais conteúdos em camaiurá ou latim, siplesmente porque não haveria vocabulário próprio para esses conteúdos.
    É perfeitamente possível desenvolver esse vocabulário específico, seja por meio de empréstimos de outras línguas, seja por meio da criação de novos termos na língua em questão, mas tal tarefa não se realizaria em pouco tempo nem com pouco esforço.
    BEARZOTI FILHO, P. Miniaurélio: o dicionário da língua portuguesa. Manual do professor. Curitiba: Positivo, 2004 (fragmento).
    Estudos contemporâneos mostram que cada língua possui sua própria complexidade e dinâmica de funcionamento. O texto ressalta essa dinâmica, na medida em que enfatiza

        A) inexistência de conteúdo comum a todas as línguas, pois o léxico contempla visão de mundo particular específica de uma cultura.
        B) existência de línguas limitadas por não permitirem ao falante nativo se comunicar perfeitamente a respeito de qualquer conteúdo.
        C) tendência a serem mais restritos o vocabulário e a gramática de línguas indígenas, se comparados com outras línguas de origem europeia.
        D) existência de diferenças vocabulares entre os idiomas, especificidades relacionadas à própria cultura dos falantes de uma comunidade.
        E) atribuição de maior importância sociocultural às línguas contemporâneas, pois permitem que sejam abordadas quaisquer temáticas, sem dificuldades ";

            string questaoMatematica = @"
    Admita que, para escovar os dentes, seja necessário, em média, 1 litro de água.
    Caso a torneira permaneça aberta durante toda a escovação, serão gastos, em média, 11 litros, havendo 
    desperdício de 10 litros.
    Considere uma família de quatro pessoas que escovam os dentes três vezes ao dia, mantendo a torneira aberta.
    Em 365 dias, o desperdício de água dessa família, em litros, será igual a:
    
        a)21900 
        b)43800 
        c)65700 
        d)87600";

            string questaoHistoria = @"
    É preciso ressaltar que, de todas as capitanias brasileiras, Minas era a mais urbanizada.
    Não havia ali hegemonia de um ou dois grandes centros. 
    A região era repleta de vilas e arraiais, grandes e pequenos, em cujas ruas muita gente circulava.
    As regiões da América portuguesa tiveram distintas lógicas de ocupação.
    Uma explicação para a especificidade da região descrita no texto está identificada na: 

        a) apropriação cultural diante das influências externas.
        b) produção manufatureira diante do exclusivo comercial.
        c) insubordinação religiosa diante da hierarquia eclesiástica.
        d) fiscalização estatal diante das particularidades econômicas.
        e) autonomia administrativa diante das instituições metropolitanas.";

            string questaoBiologia = @"
    O grafeno é uma forma alotrópica do carbono constituído por uma folha planar (arranjo bidimensional) de átomos de carbono 
    compactados e com a espessura de apenas um átomo.Sua estrutura é hexagonal, conforme a figura.Geometria do carbono
    Nesse arranjo, os átomos de carbono possuem hibridação

        a) sp de geometria linear.
        b) sp2 de geometria trigonal planar.
        c) sp3 alternados com carbonos com hibridação sp de geometria linear.
        d) sp3d de geometria planar.
        e) sp3d2 com geometria hexagonal planar.";

            string questaoQuimica = @"
    O sonorizador é um dispositivo físico implantado sobre a superfície de uma rodovia de
    modo que provoque uma trepidação e ruído quando da 
    passagem de um veículo sobre ele, alertando para a situação atípica à frente, 
    como obras, pedágios ou travessia de pedestres.
    Ao passar sobre os sonorizadores, a suspensão do veículo sofre vibrações que produzem ondas sonoras,
    resultando em um barulho peculiar.Considere um veículo que passe com velocidade constante igual a 108 km/h sobre um sonorizador
    cujas faixas são separadas por uma distância de 8 cm.

    A frequência da vibração do automóvel percebida pelo condutor durante a passagem nesse sonorizador é mais próxima de

        a) 8,6 hertz.
        b) 13,5 hertz.
        c) 375 hertz
        d) 1 350 hertz.
        e) 4860 hertz.";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bem Vindo ao Enem 2020, digite seu nome para iniciar a prova");
            Console.ForegroundColor = ConsoleColor.Gray;
            nomeAluno = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("digite o nome de sua escola");
            Console.ForegroundColor = ConsoleColor.Gray;
            nomeEscola = Console.ReadLine();

            Boolean continuar = true;

            while (continuar)
            {
                totalQuestoes = 5;

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("vamos começar.... ");
                Console.WriteLine("materia português:digite enter pra continuar");
                Console.ReadLine();
                //Inicio da questão de português
                Console.WriteLine(questaoPortugues);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("informe a alternativa correta:");
                Console.ForegroundColor = ConsoleColor.Gray;
                resposta = Console.ReadLine();


                if (resposta != "c")
                {
                    totalQuestoes = totalQuestoes - 1;
                }
                //inicio questao de matematica

                Console.WriteLine("Matematica:");
                Console.WriteLine(questaoMatematica);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("digite a alternaiva correta");
                Console.ForegroundColor = ConsoleColor.Gray;
                resposta = Console.ReadLine();

                if (resposta != "b")
                {
                    totalQuestoes = totalQuestoes - 1;
                }

                //Inicio da Questao de História

                Console.WriteLine("HISTORIA");
                Console.WriteLine(questaoHistoria);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("informe a alternativa correta");
                Console.ForegroundColor = ConsoleColor.Gray;
                resposta = Console.ReadLine();
                if (resposta != "b")
                {
                    totalQuestoes = totalQuestoes - 1;
                }

                //Inicio da questao de biologia
                Console.WriteLine(questaoBiologia);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("informe a alternativa correta");
                Console.ForegroundColor = ConsoleColor.Gray;
                resposta = Console.ReadLine();
                if (resposta != "b")
                {
                    totalQuestoes = totalQuestoes - 1;
                }
                //inicio questao de quimica
                Console.WriteLine(questaoQuimica);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("informe a alternativa correta");
                Console.ForegroundColor = ConsoleColor.Gray;
                resposta = Console.ReadLine();

                if (resposta != "c")
                {
                    totalQuestoes = totalQuestoes - 1;
                }

                //iniciando avaliacao da prova

                if (totalQuestoes >= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("voçê acertou " + totalQuestoes + " no total de 5. voçê passou no enem 2020 ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(nomeAluno + " congratulations my little friend");
                    continuar = false;
                    Console.WriteLine("Digite Enter para salvar sua prova e sair de férias");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("voçê acertou  " + totalQuestoes + " questões. Para passar é preciso acertar mais de 4.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(nomeAluno + " , volte para a escola " + nomeEscola + " e estude mais");
                    Console.WriteLine("PRESTE ATENÇÃO NO SEU PROFESSOR");
                    
                    Console.Beep(300, 500);
                    Thread.Sleep(50); 
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(250, 500);
                    Thread.Sleep(50);
                    Console.Beep(350, 250);
                    Console.Beep(300, 500);
                    Thread.Sleep(50);
                    Console.Beep(250, 500);
                    Thread.Sleep(50);
                    Console.Beep(350, 250);
                    Console.Beep(300, 500);
                    Thread.Sleep(50); 
                    
                    Console.WriteLine("Você quer tentar realizar a prova novamente? Digite S ou N");
                    var respostaContinuaProva = Console.ReadLine();

                    if(respostaContinuaProva == "n")
                        continuar = false;
            
                }
                
            }

        }
    }
}
