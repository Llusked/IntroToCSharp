using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : BasePickup
{
    public float pickupDelay = 0.5f;

    public bool AllPickedUp = true;
    public int pointValue = 1;



    protected override void ApplyPickup(Player target)
    {
        // base.ApplyPickup(target);
        target.points += pointValue;

    }


}    

//bool allPickedUp;

    // public AudioSource audioSource;
    // public AudioClip clip;

    //void Start()
    //{
    //    audioSource = GetComponent<AudioSource>();
    //}        
    //if(AllPickedUp == true)
        //{
        //    Debug.Log("is working");
        //}
        //else
        //{
        //    Debug.Log("Not Working");
        //}
        //if so give he player a point
