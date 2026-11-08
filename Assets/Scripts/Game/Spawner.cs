using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _Spawntimer, _SpawnInterval = 3f;

    public GameObject[] Enemy;

    void Update()
    {
        _Spawntimer -= Time.deltaTime;
        if(_Spawntimer <= 0)
        {
            _Spawntimer = _SpawnInterval;
            //SpawnEnemy();


        
        }
        
    }
    private void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, Enemy.Length);
        GameObject SpawnedObject = GameObject.Instantiate(Enemy[randomEnemy]);
        SpawnedObject.transform.position = transform.position;
        
    }
}
