using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;
    [SerializeField] float minSpawnRange;
    [SerializeField] float maxSpawnRange;

    [SerializeField] GameObject gameObject;
    Vector2 position;
    float spawnRange;
    bool spawn = true;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        
        while (spawn)
        {
            calculateSpawnRange();
            yield return new WaitForSeconds(spawnRange);
            Spawn();
        }
    }

    private void calculateSpawnRange()
    {
        spawnRange = Random.Range(minSpawnDelay, maxSpawnDelay);
       
    }
    private void stopSpawn()
    {
        spawn = false;
    }
    private void Spawn()
    {
        position = new Vector2(Random.Range(minSpawnRange, maxSpawnRange),-6);
        GameObject game= Instantiate(gameObject, position,Quaternion.identity) as GameObject;
    }

}
