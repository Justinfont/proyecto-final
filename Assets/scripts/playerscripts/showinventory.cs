using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showinventory : MonoBehaviour
{
    public GameObject Hud;
    public GameObject lantern;
    public AudioSource lanternOnAndOff;
    [SerializeField]
    [Range(0f,30)]
    public float lanternbattery;
    [SerializeField]
    [Range(0f,60f)]
    public float maxbattery;

    public bool lanterncooldown;

    
    // Start is called before the first frame update
    void Start()
    {
     lanterncooldown = false;
     itemmanager.redtext = false;
     maxbattery = 20;
    }

    // Update is called once per frame
    void Update()
    {
    lookinventory();
    headlight();
    lanternturnoff();
    }

    private void lookinventory()
    {
             if (Input.GetKeyDown(KeyCode.I))
             {
                if(Hud.activeInHierarchy == false)
                {Hud.SetActive(true);
                 HudManager.instance.SetSelectedText(itemmanager.Key.ToString());
                 Debug.Log("open inventory");

                }
                else
                {
                Hud.SetActive(false);    
                }
             }
   
    }

    private void headlight() 
    {
         if (Input.GetKeyDown(KeyCode.L))
             {
               if ((itemmanager.lanternobtained == true) && (lanterncooldown == false)){
                if(lantern.activeInHierarchy == false)
                {lantern.SetActive(true);
                lanternOnAndOff.Play();
                }
                else
                {
                lantern.SetActive(false);
                lanternOnAndOff.Play();    
                }
             }  }
    }

    private void lanternturnoff()
    {
      if (itemmanager.lanternobtained == true){
      itemmanager.batteryleftstatic =  lanternbattery;
   //HudManager.instance.SetSelectedText(itemmanager.batteryleftstatic.ToString()); 

     if((lantern.activeInHierarchy == true))
     {
      if(lanternbattery > 0 ){
      lanternbattery -= Time.deltaTime * 5;
     }}
     else
     {
      if (lanternbattery < maxbattery){
      lanternbattery += Time.deltaTime * 5;
     }}
     if (lanternbattery <= 0) 
     {lantern.SetActive(false);
     lanternOnAndOff.Play();
      lanterncooldown = true;
      itemmanager.redtext = true;     
     } 
   if (lanternbattery > 20)
    {lanterncooldown = false;
    itemmanager.redtext = false;
    }
        }
    }
}
