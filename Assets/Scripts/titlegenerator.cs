using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class titlegenerator : MonoBehaviour
{
    public string myTitleText;
   
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
        
    GameObject.FindGameObjectWithTag("titleinfo").GetComponent<TextMeshProUGUI>().text = myTitleText;
     GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = true;
   

    }


    private void OnTriggerExit(Collider other){
    
            
        GameObject.FindGameObjectWithTag("titleinfo").GetComponent<TextMeshProUGUI>().text = "";
             GameObject.FindGameObjectWithTag("canvas").GetComponent<Canvas>().enabled = false;
    }


}