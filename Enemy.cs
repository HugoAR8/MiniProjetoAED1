using System;


class Enemy{
  //atributos misc//
  private string tipo;
  
  //atributos defensivos//
  private int life;

  //atributos ofensivos//
  private int damage;

  public Enemy(string t, int l,int d){
    tipo = t;
    life = l;
    damage = d;
  }

  public int getDamage(){
    return damage;
  }
  
  public string getTipo(){
    return tipo;
  }
  public int getLife(){
    return life;
  }

  public void tomarDano(int d){
    life-=d;
  }

  public bool morto(){
    if(life <=0){
      return true;
    }else{
      return false;
    }
  }
  
}