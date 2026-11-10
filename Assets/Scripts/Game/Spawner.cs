using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _Spawntimer, _SpawnInterval = 3f;

    public GameObject Enemy;
    [SerializeField] private ObjectPooler pool;

    void Update()
    {
        _Spawntimer -= Time.deltaTime;
        if(_Spawntimer <= 0)
        {
            _Spawntimer = _SpawnInterval;
            SpawnEnemy();


        
        }
        
    }
    private void SpawnEnemy()
    {
        GameObject SpawnedObject = pool.GetPooleObject();
        SpawnedObject.transform.position = transform.position;
        SpawnedObject.SetActive(true);
    }
}
