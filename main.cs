/*
  Fazer um programa com no minímo duas classes em que uma tenha atributos da outra no minimo 3 atributos, 3 metodos e trabalhar com manipulação de arquivos.

  Player e a arma dele.




  Praticar é viver!

  Crie um mini projeto de qualquer natureza contendo as 
  seguintes especificações:
  - Duas Classes;
  - Ao menos 3 Atributos para cada clase 
  (com pelo menos 1 getter e Setter);
  - 3 Métodos cada;
  - Ao menos 2 construtores cada (vazio e com parâmetros)
  - Torne a relação das classes uma relação de dependência(
  Uma classe contém a Outra);
  - Crie ao menos um método contendo uma manipulação de 
  Lista (Add() ) 
  - Crie ao menos um método passando uma classe como 
  parâmetro e manipulando os atributos delas
  
  Use: tiny.cc/cartaoExemplo6 como ajuda
  
  Crie um repositório em seu GitHub para abarcar a 
  solução e faça ao menos 1 commit;
*/

using System.Collections.Generic;
using System;

class MainClass {
  public static void Main (string[] args) {
    List<Enemy> inimigosDerrotados = new List<Enemy>();
    string decisao ;
    Console.WriteLine("Digite o seu nome, nobre aventureiro.");
    string nome = Console.ReadLine();
    Random rand = new Random();
    int vida = rand.Next(120-100)+100;
    Player player = new Player(nome,vida);  

    while(player.vivo() == true){
      Console.Clear();
      decisao = "";
      Console.WriteLine("Bem vindo {0}! Gostaria de explorar a floresta(f) ou a caverna(c) ?",nome);
      decisao = Console.ReadLine();
      if(decisao == "f"){
        decisao = "";
        //Floresta
        Console.WriteLine("Então você decidiu ir até a floresta, ao chegar la, a primeira coisa que você vê é um pequeno goblin solitário. O que  deseja fazer, ataca-lo(a) ou ignorar(i) ?");
        decisao = Console.ReadLine();
        if(decisao == "a"){
          //atacou
          Enemy goblin = new Enemy("Goblin",20,4);
          Console.WriteLine("Tipo de inimigo {0}/nVida do inimigo {1}/nAtaque do inimigo {2}",goblin.getTipo(),goblin.getLife(),goblin.getDamage());
          if(goblin.morto() == true){
            inimigosDerrotados.Add(goblin);
          }


        }else if(decisao == "i"){
          //ignorou

        }else{
          //não fez nada
          Console.WriteLine("Com toda a sua confusão a única coisa que você foi capaz de    fazer foi ficar parado tentando decidir, até que começou a     crescer vinhas em você e você se tornou parte da floresta. ");
          player.tomarDano(5000);
        }

      }else if(decisao == "c"){
        //Caverna

      }else{
        //Errou o comando
        Console.Clear();
        Console.WriteLine("Parece que você não queria se aventurar, você viveu uma boa    vida, calma e sem nenhum problema. Uma vida chata e longa.");
        player.tomarDano(5000);
      }
    }
  }
}