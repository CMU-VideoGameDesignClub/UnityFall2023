using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign your enemy prefab in the Inspector
    public float spawnInterval = 5f; // Time interval in seconds between spawns

    [SerializeField] private AudioClip _clip;

    private void Start()
    {
        // Start spawning enemies using a coroutine
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true) // This will keep spawning enemies indefinitely
        {
            // Instantiate an enemy at the spawner's position and rotation
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SoundManager.Instance.PlaySound(_clip);

            // Wait for the specified spawn interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
