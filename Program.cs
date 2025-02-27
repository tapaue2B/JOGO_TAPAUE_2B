﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static string? nome, classe, local, l1, l2, l3;
    static int atk, def, spe;

    static string? itemb1, itemb2, itemb3, itemb4, itemb5;
    static string? dica1, dica2, dica3, dica4, dica5;

    static string? inimigo1 = "vivo",inimigo2 = "vivo";

    static int atkI1, defI1, speI1;

    static void Main()
    {
        continua();
        menu();
    }

    static void menu()
    {
        Console.Clear();
        int inicio;
        Console.WriteLine("Seja bem vindo(a) ao melhor jogo RPG de todos os mundos");
        Console.WriteLine("BOLA OF THE GOLD");
        Console.WriteLine("");
        Console.WriteLine("MENU");
        Console.WriteLine("1-jogar");
        Console.WriteLine("2-Introdução");
        Console.WriteLine("3-Desenvolvedores");
        Console.WriteLine("4-Sair");
        int.TryParse(Console.ReadLine(), out inicio);

        switch (inicio)
        {
            case 1:
                novoJogo();
                break;
            case 2:
                introducao();
                break;
            case 3:
                equipe();
                break;
            case 4:
                break;
            default:
                menu();
                break;
        }
    }
    static void novoJogo()
    {
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("09:00");
        Console.WriteLine("Budega do edin salgados");
        Console.ReadLine();
        Console.Clear();
        do
        {
            Console.Write("Qual seu nome:");
            nome = Console.ReadLine();
            Console.Clear();
        } while (nome == "");
        personagem();
    }

    static void personagem()
    {
        int numPer;
        Console.Clear();
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("1-Caça sapo = ATK:225 DEF:150 SPE:75 ");
        Console.WriteLine("2-Azetorto = ATK:180 DEF:135 SPE:135 ");
        Console.WriteLine("3-Anão = ATK:250 DEF:135 SPE:65 ");
        Console.WriteLine("4-Livia = ATK:180 DEF:180 SPE:90 ");
        Console.WriteLine("5-Amapeido = ATK:225 DEF:75 SPE:150 ");
        Console.WriteLine("6-Executor(vai e volta) = ATK:75 DEF:150 SPE:225 ");
        int.TryParse(Console.ReadLine(), out numPer);

        switch (numPer)
        {
            case 1:
                classe = "Caça-sapo";
                atk = 225;
                def = 150;
                spe = 75;
                confirmar();
                break;
            case 2:
                classe = "Azetorto";
                atk = 180;
                def = 135;
                spe = 75;
                confirmar();
                break;
            case 3:
                classe = "Anão";
                atk = 250;
                def = 135;
                spe = 65;
                confirmar();
                break;
            case 4:
                classe = "Livia";
                atk = 180;
                def = 180;
                spe = 90;
                confirmar();
                break;
            case 5:
                classe = "Amapeido";
                atk = 225;
                def = 75;
                spe = 150;
                confirmar();
                break;
            case 6:
                classe = "Executor";
                atk = 75;
                def = 150;
                spe = 225;
                confirmar();
                break;
            default:
                personagem();
                break;

        }
    }

    static void confirmar()
    {
        Console.Clear();
        int resp;
        Console.WriteLine("Você confirma a classe escolhida?");
        Console.WriteLine("");
        Console.WriteLine("1-Sim");
        Console.WriteLine("2-Não");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                edin();
                break;
            case 2:
                personagem();
                break;
            default:
                confirmar();
                break;
        }
    }

    static void edin()
    {
        Console.Clear();
        Console.WriteLine($"Edin: Olá {nome} oq tu vai querer hoje?");
        Console.ReadLine();
        Console.WriteLine(nome + ": Eai edin tem oq ai hoje?");
        Console.ReadLine();
        Console.WriteLine($"Edin: Pae tem o Mixtão, pitchulinha e café");
        Console.ReadLine();
        Console.Clear();
        escolha();
    }

    static void escolha()
    {
        int edin;
        Console.Clear();
        Console.WriteLine($"Edin: Vai querer o que então?");
        Console.WriteLine("");
        Console.WriteLine("1-Mixtão -> aumento de 15% do ATK na batalha");
        Console.WriteLine("2-pitchulinha -> aumento de 15% do DEF na batalha");
        Console.WriteLine("3-café -> aumento de 15% do SPE na batalha");
        int.TryParse(Console.ReadLine(), out edin);
        Console.Clear();

        switch (edin)
        {
            case 1:
                itemb1 = "Mixtão";
                babarosa();
                break;
            case 2:
                itemb1 = "pitchulinha";
                babarosa();
                break;
            case 3:
                itemb1 = "Café";
                babarosa();
                break;
            default:
                escolha();
                break;
        }
    }

    static void babarosa()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Valeu edin pelo {itemb1}");
        Console.ReadLine();
        Console.WriteLine(nome + $" colocou o {itemb1} na mochila ");
        Console.ReadLine();
        Console.WriteLine("Edin: Ei pae vai pagar não?");
        Console.ReadLine();
        Console.WriteLine(nome + ": Vou sim jajá kkkkkkk");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Barbarosa passa pela budega do edin...");
        Console.ReadLine();
        Console.WriteLine("Barbarosa: Ei rpzd passa pro pátio aí vai ter o momento tapauense");
        Console.ReadLine();
        Console.WriteLine(nome + ":  blz meu chapa vai gerar ");
        Console.ReadLine();
        Console.WriteLine("Barbarosa: Ei man oh a bola aí pra não esqueçer");
        Console.ReadLine();
        Console.WriteLine(nome + ": Vixe pode crê valeu aí");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("A rapaziada seguiu para a entrada da escola");
        Console.ReadLine();
        Console.WriteLine("Jorgin: Fala rapaziada bom dia,partiu aula né?");
        Console.ReadLine();
        Console.WriteLine(nome + ": Infezlimente né jorgin,mas pelo menos o futmesa vai gerar hoje");
        Console.ReadLine();
        Console.WriteLine("Jorgin: Tô vendo,com essa bola bonita ai vai gerar mesmo");
        Console.ReadLine();
        Console.WriteLine(nome + ": ospp...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Paulo Tiragua chega na portaria");
        Console.ReadLine();
        Console.WriteLine("Paulo Tiragua: Bom dia senhores");
        Console.ReadLine();
        Console.WriteLine("Paulo Tiragua: rapaziada essa bola ai vai ter que ficar em algum canto, não pode levar para o hino");
        Console.ReadLine();
        Console.WriteLine(nome + ": vixe pode crê");
        Console.ReadLine();
        Console.Clear();
        guardar();
    }

    static void guardar()
    {
        int resp;
        Console.Clear();
        Console.WriteLine(nome + ": Aonde vou guardar a bola");
        Console.WriteLine("");
        Console.WriteLine("1- Vaso de planta");
        Console.WriteLine("2- Estacionamento das bike");
        Console.WriteLine("3- Boca do Igor(1°B)");
        Console.WriteLine("4- Cesto de Lixo do Banheiro");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                local = "do vaso de planta";
                l1 = "terra do vaso";
                l2 = "mesas ao redor";
                l3 = "armarios";
                hino();
                break;
            case 2:
                local = "do estacionamento das bike";
                l1 = "de trás das bicicletas";
                l2 = "grama ao redor";
                l3 = "Atras da arvore";
                hino();
                break;
            case 3:
                local = "da boca do Igor(ESTATUA)";
                l1 = "estatua";
                l2 = "futmesa";
                l3 = "escada";
                hino();
                break;
            case 4:
                local = "do cesto de Lixo do banheiro";
                l1 = "pia";
                l2 = "mictorio";
                l3 = "box pichado";
                hino();
                break;
            default:
                guardar();
                break;
        }
    }

    static void hino()
    {
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Pátio");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("A bola foi guardada perto" + local);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Paulo Tiragua: Agora vamos catar o hino tapauense");
        Console.WriteLine(nome + ":tabom ");
        Console.Clear();
        Console.WriteLine("HINO:");
        Console.WriteLine("Tapaue, oh tapaue, brilho no olhar,  ");
        Console.ReadLine();
        Console.WriteLine("Com coragem e amor, vamos nos erguer,  ");
        Console.ReadLine();
        Console.WriteLine("No ritmo do tambor, vamos celebrar,  ");
        Console.ReadLine();
        Console.WriteLine("O espírito do povo que não vai se esquecer...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(nome + ": Finalmente rapaziada,partiu futmesa krlh...");
        Console.ReadLine();
        Console.WriteLine(nome + ": ué cade bola eu juro que tinha deixado aqui perto " + local);
        Console.ReadLine();
        perda();
    }

    static void perda()
    {
        int resp;
        Console.Clear();
        Console.WriteLine(nome + ": E agora oq eu faço?");
        Console.WriteLine("1- Ir para coordenação");
        Console.WriteLine("2- Procurar pistas no local que foi escondido");
        Console.WriteLine("3- Falar com as pessoas em volta");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                coordenacao();
                break;
            case 2:
                procura1();
                break;
            case 3:
                falar();
                break;
            default:
                perda();
                break;
        }
    }

    static void coordenacao()
    {
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Coordenação ensino fundamental I");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(nome + $": Ei cassiano mah, nois tava lá hino se liga e nois tinha deixado a bola ali no {local}");
        Console.ReadLine();
        Console.WriteLine(nome + ": Ai quando nois voltou a bola não tava mais lá, se liga ");
        Console.ReadLine();
        Console.WriteLine("Cassiano: Mah eu não posso fazer muita coisa não oh");
        Console.ReadLine();
        Console.WriteLine("Cassiano: Mas tem alguem que pode ajudar...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Savio aparece misteriosamente...");
        Console.ReadLine();
        Console.WriteLine("Sávio: O que está acontecendo aqui, posso saber?");
        Console.ReadLine();
        Console.WriteLine(nome + $": A gente perdeu nosso bola perto {local}");
        Console.ReadLine();
        Console.WriteLine(nome + ": Queriamos saber se você pode nos ajudar");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Sávio: Depois de ouvir esses relatos, eu estou decidido");
        Console.ReadLine();
        Console.WriteLine("Sávio: EU VOU AJUDAR VOCÊS!!");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("SÁVIO AGORA É SEU GUIA");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Sávio seguirá com você na sua jornada!! ");
        Console.ReadLine();
        Console.Clear();
        continua();
    }

    static void continua()
    {
        Console.Clear();
        Console.WriteLine("Savio:nossa jornada vai começar pelas salas da masmorra do fundamental 2");
        Console.ReadLine();
        continuafund2();
    }
    static void continuafund2()
    {
        if(inimigo1 == "vivo")
        {
        int resp;
        Console.Clear();
        Console.WriteLine("Savio: qual sala você quer ir?");
        Console.WriteLine("");
        Console.WriteLine("1 -  6° ANO");
        Console.WriteLine("2 -  7° ANO");
        Console.WriteLine("3 -  8° ANO");
        int.TryParse(Console.ReadLine(), out resp);
        switch(resp)
        {
            case 1:
                anof1();
                atkI1 = 50;
                defI1 = 250;
                speI1 = 100;
                break;
            case 2:
                anof1();
                atkI1 = 100;
                defI1 = 250;
                speI1 = 50;
                break;
            case 3:
                anof1();
                atkI1 = 250;
                defI1 = 100;
                speI1 = 50;
                break;
            default:
                continuafund2();
                break;
        }
        }
        else if(inimigo1 == "morto")
        {
                    int resp;
        Console.Clear();
        Console.WriteLine("qual sala você quer ir?");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("1 -  6° ANO");
        Console.WriteLine("2 -  7° ANO");
        Console.WriteLine("3 -  8° ANO");
        Console.WriteLine("4 -  9° ANO");
        int.TryParse(Console.ReadLine(), out resp);
        switch(resp)
        {
            case 1:
                anof1();
                break;
            case 2:
                anof1();
                break;
            case 3:
                anof1();
                break;
            case 4:
                ano9();
                atkI1= 150;
                defI1 = 200;
                speI1 = 150;
                break;
            default:
                continuafund2();
                break;
        }
        }

        else if(inimigo2 == "morto")
        {
                    int resp;
        Console.Clear();
        Console.WriteLine("Savio: E agora onde você quer ir?");
        Console.WriteLine("");
        Console.ReadLine();
        Console.WriteLine("1 -  6° ANO");
        Console.WriteLine("2 -  7° ANO");
        Console.WriteLine("3 -  8° ANO");
        Console.WriteLine("4 -  9° ANO");
        Console.WriteLine("5 -  Ensino médio");
        int.TryParse(Console.ReadLine(), out resp);
        switch(resp)
        {
            case 1:
                anof1();
                break;
            case 2:
                anof1();
                break;
            case 3:
                anof1();
                break;
            case 4:
                ano9();
                break;
            case 5:
                ensinoMedio();
                break;
            default:
                continuafund2();
                break;
        }
        }
    }

    static void anof1()
    {
        Console.Clear();
        Console.WriteLine("Savio: Chegamos, vou perguntar se alguem viu algo");
        Console.ReadLine();
        Console.WriteLine("Savio: Ola gente alguem aqui ");
        
    }

    static void ano9()
    {
        Console.Clear();
        Console.WriteLine("ACABOU");
        Console.ReadLine();
    }

    static void ensinoMedio()
    {
        Console.Clear();
        Console.WriteLine("ACABOU");
        Console.ReadLine();
    }

    static void procura1()
    {
        Console.Clear();
        Console.WriteLine(nome + ": Agora não nos resta escolha, VAMOS ATRÁS DE PISTAS!");
        Console.ReadLine();
        Console.Clear();
        procuralocal();
    }

    static void procuralocal()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Aonde você deseja procurar? ");
        Console.WriteLine("");
        Console.WriteLine($"1- {l1}");
        Console.WriteLine($"2- {l2}");
        Console.WriteLine($"3- {l3}");
        Console.WriteLine("4- Voltar para o pátio");
        int.TryParse(Console.ReadLine(), out resp);
        Console.Clear();

        switch (resp)
        {
            case 1:
                dicaFalsa1();
                break;
            case 2:
                dicaFalsa2();
                break;
            case 3:
                DicaVerdadeira();
                break;
            case 4:
                perda();
                break;
            default:
                procuralocal();
                break;
        }

    }

    static void dicaFalsa1()
    {
        Console.Clear();
        Console.WriteLine($"Não foi encontrado nada em {l1}.");
        Console.ReadLine();
        procuralocal();
    }

    static void dicaFalsa2()
    {
        Console.WriteLine($"Não foi encontrado nada em {l2}");
        Console.ReadLine();
        procuralocal();
    }

    static void DicaVerdadeira()
    {
        if (dica1 == "dica 1")
        {
            Console.WriteLine($"Não foi encontrado nada em {l3}.");
            Console.ReadLine();
            procuralocal();
        }
        else
        {
            dica1 = "dica 1";
            Console.WriteLine(nome + ": Olha!!!, oq é isso?");
            Console.ReadLine();
            Console.WriteLine(nome + ": Uma dica!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Dica 1: Um fio de cabelo ruivo");
            Console.ReadLine();
            Console.WriteLine(nome + ": Interessante");
            Console.ReadLine();
            procuralocal();
        }

    }
    static void falar()
    {
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Portão de entrada da escola tapaue");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(nome + ": Agora estamos decidido: VAMOS FALAR COM AS PESSOAS AO REDOR!");
        Console.ReadLine();
        fala1();
    }

    static void fala1()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Com quem você deseja falar?");
        Console.WriteLine("");
        Console.WriteLine("1- Sergio (Insepetor)");
        Console.WriteLine("2- mariana (aluna)");
        Console.WriteLine("3- Carlão (Professor)");
        Console.WriteLine("4- Voltar para o pátio");
        int.TryParse(Console.ReadLine(), out resp);
        Console.Clear();

        switch (resp)
        {
            case 1:
                sergio();
                break;
            case 2:
                mariana();
                break;
            case 3:
                carlao();
                break;
            case 4:
                perda();
                break;
            default:
                fala1();
                break;
        }
    }

    static void sergio()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Ei Sérgio, a gente perdeu a nossa bola perto {local}, você viu alguma coisa");
        Console.ReadLine();
        Console.WriteLine($"Sérgio: eu vi quando vocês colocaram a bola {local}, e vi dois vultos passando pelo {l3} mas não vi quem era ao certo");
        Console.ReadLine();
        Console.WriteLine(nome + ":Obrigado pela informação Sérgio, valeu ");
        Console.ReadLine();
        Console.Clear();
        fala1();
    }

    static void mariana()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Mariana man a gente perdeu a nossa bola perto {local}, tu viu alguém com a bola?");
        Console.ReadLine();
        Console.WriteLine($"Mariana: não vi nada mas, vi uns meninos falando sobre a bola pelo {l2} mas não sei quem são os eles ");
        Console.ReadLine();
        Console.WriteLine(nome + " valeu, vou ver se consigo saber mais quem são esses caras ");
        Console.ReadLine();
        Console.WriteLine();
        Console.Clear();
        fala1();
    }

    static void carlao()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Ei Carlão, a gente perdeu a nossa bola perto {local}, você viu se alguem pegou?");
        Console.ReadLine();
        Console.WriteLine($"Carlão: eu estava no {local}, e vi umas pessoas no {l1} mas eles passaram correndo não consegui ver quem era");
        Console.ReadLine();
        Console.WriteLine(nome + ":Tá certo Carlota, valeu ");
        Console.ReadLine();
        Console.Clear();
        fala1();
    }


    static void introducao()
    {
        Console.Clear();
        Console.WriteLine("A rapaziada estava comendo um edin quando foram à Reformatorio Tapaué para cantar o hino tapauense. ");
        Console.WriteLine("Lá, Paulo Tirágua impediu-os de usar a bola of the Gold, que foi escondida.");
        Console.WriteLine("Depois do hino, eles retornaram local para buscar a bola, mas quando olharam, a bola desapareceu misteriosamente.");
        Console.WriteLine("Eles foram então à coordenação para relatar a perda");
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        menu();
        Console.Clear();
    }

    static void equipe()
    {
        Console.Clear();
        Console.WriteLine("EQUIPE TAPAUÉ - A BOLA OF THE GOLD ");
        Console.WriteLine("");
        Console.WriteLine("MEMBROS: ");
        Console.WriteLine("");
        Console.WriteLine("LUCAS AMARAL - @lucas_amaralg");
        Console.WriteLine("NIORD MANEIRO -  ");
        Console.WriteLine("EDUARDO GOMES - ");
        Console.WriteLine("SAMUEL BRADÃO -  ");
        Console.WriteLine("LUÍS GUSTAVO - ");
        Console.WriteLine("LUCAS AZEVEDO -  ");
        Console.WriteLine("MARIANA VITÓRIA - ");
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        menu();
    }
}