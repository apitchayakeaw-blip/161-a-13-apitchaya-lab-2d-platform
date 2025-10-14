using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    public int Health 
        { 
           get => health ; 
           set => health = (value < 0) ? 0: value; 
        }

    protected Animater anim;
    protected Rigidbody rb;

    //meathods

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage} current health : {Health}");

    }

    public bool IsDead()
    {
        if (Health <= 0) 
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead and destroyed");
            return true;
        }
        else return false;
    }
}

