using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorbutton : MonoBehaviour
{
    private bool alreadyopen;
    public AudioSource doorsound;
    public GameObject doormove;
    // Start is called before the first frame update
    void Start()
    {
    alreadyopen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
     Debug.Log("door unlocked");
     
    if (alreadyopen == false)
        {
    doormove.transform.position = doormove.transform.position + Vector3.up * 9 ;
    doorsound.Play();
    alreadyopen = true;

        }
    }
}
