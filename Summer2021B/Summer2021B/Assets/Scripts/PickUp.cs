using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    public AudioSource pickUpSound;
    private void OnMouseDown() 
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("destination").transform;
    }
    
    private void OnMouseUp() 
    {
        this.transform.parent = null;   
        GetComponent<Rigidbody>().useGravity = true;
        pickUpSound.PlayDelayed(0.5f);
    }
}
