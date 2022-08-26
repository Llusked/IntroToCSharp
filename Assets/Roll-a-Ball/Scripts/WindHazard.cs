using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindHazard : BaseHazard
{
    public float windStrength = 3;

    private Player affectedPlayer;
    private void Update()
    {
        Rigidbody playerRB = affectedPlayer.GetComponent<Rigidbody>();
    }

    protected override void OnPlayerEnter(Player target)
    {
        affectedPlayer = target;
    }

    protected override void OnPlayerExit(Player target)
    {
        affectedPlayer = null;
    }
}
