using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;
    private readonly List<GameObject> _objectPool = new();
    
    void FixedUpdate(){
        GameObject _objectFromPool = GetObjectFromPool();
        if (_objectFromPool == null)
        {
            print("this");
            _objectFromPool = Instantiate(objPrefab, transform.position, Quaternion.identity);
            _objectPool.Add(_objectFromPool);
        }
        _objectFromPool.transform.position = transform.position;
        _objectFromPool.SetActive(true);
    }

    GameObject GetObjectFromPool()
    {
        return _objectPool.Find(go => !go.activeInHierarchy);
    }
}
