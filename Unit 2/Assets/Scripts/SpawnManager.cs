using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private float _spawnRangeX = 20f;
    [SerializeField]
    private float _spawnPosZ = 20f;
    [SerializeField]
    private GameObject[] _animalPrefabs;
    [SerializeField]
    private float _startDelay =  2f;
    [SerializeField]
    private float _spawnInterval = 1.5f;

    private void Start() {
        InvokeRepeating("spawnRandomAnimal", _startDelay, _spawnInterval);
    }

    private void spawnRandomAnimal() {
        int animalIndex = Random.Range(0, _animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        Instantiate(_animalPrefabs[animalIndex], spawnPos, _animalPrefabs[animalIndex].transform.rotation);
    }
}
