using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision detected on bullet");
            collision.gameObject.GetComponent<EnemyBehaviour>()?.TakeDamage();
        }
    }
}
