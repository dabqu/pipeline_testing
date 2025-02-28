using UnityEngine;
using UnityEngine.PlayerLoop;

public class CubeController : MonoBehaviour
{
    public int foo = 10;
    public GameObject cubePrefab;

    void Awake()
    {
        Debug.Log("Awoken");
    }

    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        Debug.Log("Update");    
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    
}
