using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HudManager : MonoBehaviour
{
  
   [SerializeField] private Text keys;
   [SerializeField] private Text batteryleft;
  // public Text colortext;
   public Color cantuselantern;
    public Color canuselantern;
    
   
  public static HudManager instance;
    // Start is called before the first frame update
    void Start()
    {
    Awake();    
    }

    // Update is called once per frame
    void Update()
    { 
      colorchagelantern(); 
  batteryleft.text = itemmanager.batteryleftstatic.ToString();
    }

      private void Awake()

  {

    if (instance == null)
    {
      instance = this;
      Debug.Log(instance);
      DontDestroyOnLoad(gameObject);
      
    }
  }

    public void SetSelectedText(string newText)
    {
        keys.text = newText;
        
        
        
    }

  public void colorchagelantern()
  {
    if (itemmanager.redtext == true)
    {
    batteryleft.color =  cantuselantern; 
    }
    else
    {
     batteryleft.color = canuselantern; 
    }
  }
}