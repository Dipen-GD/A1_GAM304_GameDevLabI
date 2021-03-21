using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject[] spawnees;
   
    // position of spawn
    public Vector3 spawnPos;

    // time delay till the next spawn
    public float spawnDelay;

    // min and max delay values till the next spawn
    public float spawnMaxDelay;
    public float spawnMinDelay;

    // how long before the spawning starts
    public int startSpawn;

    // value to determine which random spawnees spawn first
    int randSpawnee;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        // randomizing spawn delay between each spawn
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startSpawn);
        while(true)
        {
            randSpawnee = Random.Range(0, spawnees.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPos.x, spawnPos.x), 1, Random.Range(-spawnPos.z, spawnPos.z));
            Instantiate(spawnees[randSpawnee], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnDelay);
        }


    }
}
