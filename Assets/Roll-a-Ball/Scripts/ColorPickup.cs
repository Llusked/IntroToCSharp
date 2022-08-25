using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : MonoBehaviour
{
    public Material rewardMaterial;

    private void OnTriggerEnter(Collider other)
    {

        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            player.colorMaterials.Add(rewardMaterial);

            Destroy(gameObject);
        }

    }



}
