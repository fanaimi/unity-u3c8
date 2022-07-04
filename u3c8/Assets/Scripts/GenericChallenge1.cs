using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{
    [SerializeField] private GameObject m_cubePrefab;
    [SerializeField] private Transform m_cubesHolder;
    private Vector3 m_cubePosition1 = new Vector3(1, 1, 1);
    private Vector3 m_cubePosition2 = new Vector3(2, 2, 2);

    // Start is called before the first frame update
    void Start()
    {
        GenericMethod<TestScript>(
            m_cubePrefab, 
            m_cubePosition1, 
            Quaternion.identity, 
            m_cubesHolder
        );


        GenericMethod<AnotherTest>(
            m_cubePrefab,
            m_cubePosition2,
            Quaternion.identity,
            m_cubesHolder
        );
    }

    private void GenericMethod<T>(
        GameObject newObject, 
        Vector3 position, 
        Quaternion rotation, 
        Transform parent) where T : MonoBehaviour
    {
        Debug.Log($"Adding {typeof(T)} to {newObject.name} ");
        GameObject newObj = Instantiate(newObject, position, rotation, parent);
        var addedComponent = newObj.AddComponent<T>();
        addedComponent.enabled = false;
    }
}
