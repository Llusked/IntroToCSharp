using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePickup : BasePickup
{
    public int newSize = 2;
    public int playerSize = 1;

    protected override void ApplyPickup(Player target)
    {
        //base.ApplyPickup(target);
        target.transform.localScale = Vector3.one * newSize;
    }
}
