using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Renderer enemyRenderer;

    void Start()
    {
        enemyRenderer = GetComponent<Renderer>();  // get renderer of enemy
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyRenderer.material.color = Color.red;
            DestroyAfterDelay(2f);
        }
    }

    public void DestroyAfterDelay(float delay)
    {
        Invoke("DestroyEnemy", delay);
    }

    /**
     * turns red and gets destroyed
     */
    public void TakeDamage()
    {
        enemyRenderer.material.color = Color.red;
        DestroyAfterDelay(2f);
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
