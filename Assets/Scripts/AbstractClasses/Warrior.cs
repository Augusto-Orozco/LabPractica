using UnityEngine;

public class Warrior : Character
{
    private void Awake()
    {
        characterName = "Warrior";
        damage = 20;
    }

    public override void Attack()
    {
        Debug.Log(characterName + " attacks with a sword for " + damage + " damage!");
    }
}
