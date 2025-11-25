using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabToPool; // prefab mau
    [SerializeField]
    private int _amountToPool;        // so luong tao san
    [SerializeField]
    private Stack<GameObject> pooledObjects = new();

    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    // 3. Pool Manager
    void Start()
    {
        // khoi tao cac doi tuong va dua vao pool
        for (int i = 0; i < _amountToPool; i++)
        {
            GameObject obj = Instantiate(_prefabToPool);
            pooledObjects.Push(obj); // them vao kho luu tru
            obj.SetActive(false); // tat hoat dong
        }
    }
    
    // ham lay doi tuong tu pool
    public GameObject GetPooledObject()
    {
        // neu pool het doi tuong, thi tao them hoac tra ve null
        if (pooledObjects.Count == 0)
        {
            // tao them
            GameObject objOther = Instantiate(_prefabToPool);
            pooledObjects.Push(objOther);
            objOther.SetActive(false);

            // in ra loi - TODO

        }

        // lay doi tuong dau tien ra khoi hang doi
        GameObject obj = pooledObjects.Pop();
        obj.SetActive(true); // bat hoat dong

        // Gan them logic de biet khi nao tra ve pool

        return obj;
    }

    // ham tra doi tuong ve pool
    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
        pooledObjects.Push(obj);
    }
}
