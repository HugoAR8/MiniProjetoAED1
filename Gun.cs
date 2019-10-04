using System;

class Gun{
  //atributos ofensivos//
  private int damage;
  private int magia ;
  private int CD;


  public Gun(){
    damage = 5;
    magia = 15;
    CD = 2;
  }


  public int ataqueMagico(){
    CD = 0;
    if(CD == 2){

      return magia;

    }else{
      return 0;
    }

  }

  public int getDamage(){
    return damage;
  }


  public void upgrade(int d){
    damage+=d;
  }


}