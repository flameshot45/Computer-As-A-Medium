using UnityEngine;
public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Updates Once per Frame.
    void Update()
    {
        Death();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
        if (other.CompareTag("Bullet"))
        {
            enemyHealth -= 10;          // bullet does 10 damage
            Destroy(other.gameObject);  // destroys the bullet 
        }
    }
    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
