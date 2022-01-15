using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float _spawnIntervalMin = 3;
    private float _spawnIntervalMax = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        if (ballPrefabs.Length > 0) {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            int ballIndex = Random.Range(0, ballPrefabs.Length);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

            Invoke(nameof(SpawnRandomBall), Random.Range(_spawnIntervalMin, _spawnIntervalMax));
        }
    }
}
