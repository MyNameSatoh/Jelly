using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject[] Enemy;
    [SerializeField] private int poolSize = 5;
    private List<GameObject> _pool;

    void Start()
    {
        _pool = new List<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            CreateNewObject();
        
        }
    
    }
    private GameObject CreateNewObject()
    {
        int randomEnemy = Random.Range(0, Enemy.Length);

        GameObject obj = Instantiate(Enemy[randomEnemy], transform);
        obj.SetActive(false); 
        _pool.Add(obj);   
        return obj;
    }

    public GameObject GetPooleObject()
    {
        foreach(GameObject obj in _pool)
        {
            if (!obj.activeSelf)
            {
                return obj;
            }
        }
        return CreateNewObject();
    }
}
