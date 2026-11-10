using System;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private WavesData[] wave;
    private float _Spawntimer;
    private int _currentWaveIndex = 0;

    private WavesData currentWave => wave[_currentWaveIndex]; // xác định wave thứ mấy(tính từ 0 -> ...)


    public GameObject Enemy;
    [SerializeField] private ObjectPooler Enemy1pool;
    [SerializeField] private ObjectPooler Enemy2pool;
    [SerializeField] private ObjectPooler Enemy3pool;
    private Dictionary<EnemyType, ObjectPooler> _poolDictionary;

    private void Awake()
    {
        _poolDictionary = new  Dictionary<EnemyType, ObjectPooler>()
        {
            {EnemyType.enemy1, Enemy1pool}, 
            {EnemyType.enemy2, Enemy2pool}, 
            {EnemyType.enemy3, Enemy3pool}, 

        };
    }
    void Update()
    {
        _Spawntimer -= Time.deltaTime;
        if(_Spawntimer <= 0)
        {
            _Spawntimer =  currentWave.spawninteval;
            SpawnEnemy();


        
        }
        
    }
    private void SpawnEnemy()
    {
        if (_poolDictionary.TryGetValue(currentWave.enemydata, out var pooler))
        {
            GameObject SpawnedObject = Enemy1pool.GetPooleObject();
            SpawnedObject.transform.position = transform.position;
            SpawnedObject.SetActive(true);
        }
    }
}
