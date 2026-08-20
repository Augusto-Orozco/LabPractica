using UnityEngine;
public abstract class Character : MonoBehaviour
{
    [SerializeField] protected string characterName;
    [SerializeField] protected int damage;

    public abstract void Attack();


    //public virtual void SetName(string name)
    //{
    //    characterName = name;
    //}

    public virtual void ShowInfo()
    {
        Debug.Log(characterName + " | Damage: " + damage);
    }


}
