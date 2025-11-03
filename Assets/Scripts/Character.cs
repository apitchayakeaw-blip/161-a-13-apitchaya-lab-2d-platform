using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{

    [SerializeField] FloatingHpBar hpBar;


    private float maxHp;

    private float health;
    public float Health 
        { 
           get => health ; 
           set => health = (value < 0) ? 0: value; 
        }

    protected Animator anim;
    protected Rigidbody2D rb;


    public void Intialize(int startHealth)
    {
        maxHp = startHealth;
        Health = startHealth;
        Debug.Log($"{this.name} intial Health {this.Health}");

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        hpBar = GetComponentInChildren<FloatingHpBar>();
    }

    //meathods

    public void TakeDamage(int damage)
    {
        Health -= damage;       
        
        Debug.Log($"{this.name} took damage {damage} current health : {Health}");
        

        if (hpBar != null)
        {
            hpBar.UpdateHealthBar(Health, maxHp);
        }

        IsDead();

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

