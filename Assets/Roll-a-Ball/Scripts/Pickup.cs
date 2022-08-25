using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float pickupDelay = 0.5f;

    public bool AllPickedUp = true;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("trigger");

        //did player interact thith the object
        Player player = null;
        if(other.TryGetComponent<Player>(out player))
        {
            player.points = player.points + 1;

            Destroy(gameObject);
        }
        if(AllPickedUp == true)
        {
            Debug.Log("is working");
        }
        else
        {
            Debug.Log("Not Working");
        }
        //if so give he player a point

    }
}
