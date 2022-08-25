using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequiredItems : MonoBehaviour
{
    public List<GameObject> required;

    public GameObject target;

    private int requiredCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        bool isOnList = false;
        for(int i = 0; i < required.Count; i++)
        {
            if(required[i] == otherGO)
            {
                isOnList = true;
                break;
            }
        }

        if(isOnList)
        {
            requiredCounter++;
        }

        if(requiredCounter == required.Count)
        {
            target.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
