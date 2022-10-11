using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbuttontimer : MonoBehaviour
{
 public bool isdooropen;
    
    public AudioSource opendoor;
    public AudioSource doorclosed;
    public GameObject TimedDoor;
    public float timer;
 

    [SerializeField]
    [Range(0f,30f)]
    public float timeleft;
    public bool timerstart = false;



private void Update() {
   timetoclosedoor(); 
}


    private void OnTriggerStay(Collider other) {
    if (Input.GetKey(KeyCode.E)){

     if (isdooropen == false)
    {timer = timeleft;
    TimedDoor.transform.position = TimedDoor.transform.position + Vector3.up * 6 ;
    timerstart = true;
    opendoor.Play();
    isdooropen = true;
    }

    }

    }

 private void timetoclosedoor()
 {if(timerstart == true) 
   {timer -= Time.deltaTime;
     if (timer <= 0)
    {
        Debug.Log("doorclosed");
    TimedDoor.transform.position = TimedDoor.transform.position + Vector3.down * 6 ;
    timerstart = false;
    isdooropen = false;
    doorclosed.Play();
    }
    }
    }
    
}
