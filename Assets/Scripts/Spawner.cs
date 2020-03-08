using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> imageList;

    public float minSpeed;
    public float maxSpeed;

    public float minSpawnInterval;
    public float maxSpawnInterval;

    public float minXSpawnDirection;
    public float maxXSpawnDirection;

    public float minYSpawnDirection;
    public float maxYSpawnDirection;

    public float horizontalSpawnAmplitude;
    public float verticalSpawnAmplitude;

    public float lifespan;

    public float minSize;
    public float maxSize;

    private float timeSinceSpawn;

    void Start() {
        timeSinceSpawn = 0;
    }

    void Update() {
        timeSinceSpawn -= Time.deltaTime;
        if (timeSinceSpawn <= 0) {
            Spawn();
            timeSinceSpawn = Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    void Spawn() {
        GameObject image = imageList[Random.Range(0, imageList.Count)];
        GameObject iImage = Instantiate(image, transform.position + new Vector3 (Random.Range(-horizontalSpawnAmplitude, horizontalSpawnAmplitude), Random.Range(-verticalSpawnAmplitude, verticalSpawnAmplitude), 0), Quaternion.identity);
        iImage.GetComponent<SpawnedImage>().Init(Random.Range(minSpeed, maxSpeed), Random.Range(minXSpawnDirection, maxXSpawnDirection), Random.Range(minYSpawnDirection, maxYSpawnDirection), lifespan, Random.Range(minSize, maxSize));
    }
}
