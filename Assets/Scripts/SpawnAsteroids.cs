using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnAsteroids : MonoBehaviour
{
    [SerializeField] private GameObject[] AsteroidPrefabs;
    private float RandZ;
    [SerializeField] private float SpawnRate = 2f;
    private float nextSpawn = 0.2f;

    private void FixedUpdate()
    {
        if (Time.time > nextSpawn)
        {
            int asteroidIndex = Random.Range(0, AsteroidPrefabs.Length);
            Instantiate(AsteroidPrefabs[asteroidIndex], new Vector3(-20, 0, RandZ),
                AsteroidPrefabs[asteroidIndex].transform.rotation);
            nextSpawn = Time.time + SpawnRate;
            RandZ = Random.Range(-13f,13f);
        }
    }
}