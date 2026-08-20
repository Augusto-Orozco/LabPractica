using UnityEngine;

public class Mage : Character
{
    private void Awake()
    {
        characterName = "Mage";
        damage = 25;
    }
   

    public override void Attack()
    {
        Debug.Log(characterName + " casts a fireball for " + damage + " damage!");
    }
}
