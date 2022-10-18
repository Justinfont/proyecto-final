using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
   Rigidbody playerrigidbody;
 
   public float idletime = 6f;
    public float speed = 4f;
    [SerializeField] Animator Playeranim;
    public float turntime;
   
public float maxspeed;
    // Start is called before the first frame update
    void Start()
    {
      playerrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // playerspeed = new Vector3(1,0,0);
        Move_Forward();
        Move_Backwards();
        Turn_Left();
        Turn_Right();
        sprint();
        timerforidle();
        


    }

    
   
   public void Turn_Left() 
   {
       Playeranim.SetBool("turningleft",false);
      if (Input.GetKey(KeyCode.A))
      {
         Playeranim.SetBool("turningleft",true);
         transform.Rotate(0,-2,0);
         idletime = 10f;
      }
   }
      public void Turn_Right() 
   {
       Playeranim.SetBool("turningright",false);
      if (Input.GetKey(KeyCode.D))
      {
         Playeranim.SetBool("turningright",true); 
         transform.Rotate(0,2,0 );
         idletime = 10f;

      }
   }
   public void Move_Forward()
    {
       Playeranim.SetBool("Goingforward",false);
               if (Input.GetKey(KeyCode.W))
        {
         playerrigidbody.velocity = (transform.forward * speed);
         //transform.Translate(Vector3.forward * speed * Time.deltaTime); // no se usa mas
          Playeranim.SetBool("Goingforward",true);
         idletime = 10f;
        }
    }

    public void Move_Backwards()
    {
         Playeranim.SetBool("Goingbackwards",false);
               if (Input.GetKey(KeyCode.S))
        {
         playerrigidbody.velocity = (-transform.forward * speed);
         //transform.Translate(Vector3.back * speed * Time.deltaTime); unused
         Playeranim.SetBool("Goingbackwards",true);
         idletime = 10f;
         
        }
    }
    public void sprint() 
    {
      Playeranim.SetBool("isrunning",false);
         speed = 4;
        if (Input.GetKey(KeyCode.LeftShift))
        {
         Playeranim.SetBool("isrunning",true);
            speed = 7;
        }
    }

   public void timerforidle()
   {
   idletime -= Time.deltaTime;
   if (idletime <= 0)
      {
   Playeranim.SetBool("idleforlong",true);

      } 

   if (idletime > 0)
   {
   Playeranim.SetBool("idleforlong",false);

   }

   }

  
}

