using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public Dictionary<int, GameObject> Pool;
    [SerializeField] DataStorage ObjectStorage;

    private void Awake()
    {
        Pool = new Dictionary<int, GameObject>();
        for (int i = 0; i < ObjectStorage.SpritesStorage.Count; i++)
        {
            GameObject newObject = Instantiate(ObjectStorage.SpritesStorage[i]);
            newObject.transform.SetParent(this.transform);
            newObject.SetActive(false);
            Pool.Add(i, newObject);
        }
    }

    public GameObject GetObjectFromPool(int _ID, Transform _parentPosition)
    {
        GameObject selected = Pool[_ID];
        Pool.Remove(_ID);
        selected.transform.SetParent(_parentPosition);
        selected.transform.localPosition = Vector3.zero;
        selected.SetActive(true);
        return selected;
    }
    public void BackObjToPool(int _ID, GameObject _obj)
    {
        _obj.transform.SetParent(this.transform);
        _obj.SetActive(false);
        Pool.Add(_ID, _obj);
    }
}
