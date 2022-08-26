using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // did interact 
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
            {

            ApplyPickup(player);

            Destroy(gameObject);
            }
        
    }

    protected virtual void ApplyPickup(Player target)
    {
        // this does nothing
    }
}
