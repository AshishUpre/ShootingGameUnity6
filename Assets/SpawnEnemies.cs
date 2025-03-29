using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 GroundCoordinates = new Vector3(0, (float)-0.2000003, 0);
    public float spawnInterval = 3f;
    public int maxEnemies = 5; 
    private int enemyCount = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 2f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyCount >= maxEnemies) 
            return; // Stop spawning if max reached

        Vector3 randomPosition = GetRandomSpawnPoint();
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        enemyCount++;
        spawnInterval += 1;
    }

    /**
     * gives a random point for enemy to spawn in the Ground 
     */
    Vector3 GetRandomSpawnPoint()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        float y = GroundCoordinates.y; // Keep enemies at ground level

        return new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);
    }
}
