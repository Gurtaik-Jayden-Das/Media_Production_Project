using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxController : MonoBehaviour
{
   
   public string myText;
   
    // Start is called before the first frame update
    void Start()
    {
           GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        
        GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = myText;
     GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = true;
   

    }


    private void OnTriggerExit(Collider other){
    
            
        GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = "";
             GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = false;
    }


}