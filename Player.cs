//ideia, fazer o nome do personagem, o save no arquivo de texto, com uma varivel definindo aonde o player se encontra(exemplo "fase = 1;") pra que seja possível retornar de onde parou//



using System;

class Player{
  // atributos defensivos //
  private int maxLife;
  private int life;
  
  // atributos ofensivos //
  private int damage;

  // atributos misc //
  private string name;

  // arma //
  Gun gun = new Gun();

  public Player(string n,int l){
    maxLife = l;
    name = n;
    life = l;
    damage = gun.getDamage();
  }  

  public void tomarDano(int d){
    life -= d;
  }

  public void curar(int c){
    life += c;
    if(life > maxLife){
      life = maxLife;
    }
  }

  public bool vivo(){
    if(life > 0){
      return true;
    }else{
      return false;
    }
  }


}