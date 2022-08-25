using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode devkey = KeyCode.F;

    void Update()
    {
        if(Input.GetKeyUp(devkey))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
