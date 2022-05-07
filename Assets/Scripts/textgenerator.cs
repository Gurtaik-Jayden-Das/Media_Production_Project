using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textgenerator : MonoBehaviour
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
        
        GameObject.FindGameObjectWithTag("info").GetComponent<TextMeshProUGUI>().text = myText;
     GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = true;
   

    }


    private void OnTriggerExit(Collider other){
    
            
        GameObject.FindGameObjectWithTag("info").GetComponent<TextMeshProUGUI>().text = "";
             GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = false;
    }


}
