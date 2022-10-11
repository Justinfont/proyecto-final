using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerswitch : MonoBehaviour
{
    public bool isdooropen;
    
    public AudioSource opendoor;
    public AudioSource doorclosed;



    public GameObject doorswitch;
    public float timer;


    [SerializeField]
    [Range(0f,20f)]
    public float timeleft;
    public bool timerstart = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
     
        timetoclosedoor();

    }
private void OnCollisionExit(Collision other)
{
 if (isdooropen == false)
    {timer = 4;
    doorswitch.transform.position = doorswitch.transform.position + Vector3.up * 3 ;
    timerstart = true;
    opendoor.Play();
    isdooropen = true;
    }
}

 public void timetoclosedoor()
{
   if(timerstart == true) 
   {timer -= Time.deltaTime;
     if (timer <= 0)
    {
        Debug.Log("doorclosed");
    doorswitch.transform.position = doorswitch.transform.position + Vector3.down * 3 ;
    timerstart = false;
    isdooropen = false;
    doorclosed.Play();
    }
    }
}
}

