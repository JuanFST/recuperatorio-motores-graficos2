using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroides : MonoBehaviour
{
    public GameObject asteroidePrefab;
    float RandomY;
    Vector2 dondeSpawnea;
    public float Spawnrate = 2f;
    float siguienteSpawn = 0.0f;



    private void Update()
    {
        if(Time.time > siguienteSpawn)
        {
            siguienteSpawn = Time.time + Spawnrate;
            RandomY = Random.Range(-3.0f, 3.0f);
            dondeSpawnea = new Vector2(transform.position.x, RandomY);
            Instantiate(asteroidePrefab, dondeSpawnea, Quaternion.identity);
        }
    }
}
