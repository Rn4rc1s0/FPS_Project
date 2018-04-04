using Godot;
using System;

public class MeleeWeapon : Item, IWeapon {
  
  const int Damage = 10;
  
  public void Init(){
    
  }
  
  public int GetBaseDamage(){
    return Damage;
  }
  
  public override void Use(Item.Uses use){
    switch(use){
      case Uses.A: GD.Print("Swing"); break;
      case Uses.B: GD.Print("Guard"); break;
    }
  }
  
}
