using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SunTemple;

public class DoorKey : MonoBehaviour
{
    
    public GameObject outsideDoor;
    private DoorValue doorvalue; 
    private SunTemple.DoorController doorController;
    private GameObject thiskey;
    public AudioSource playSound;
 
 
    // Start is called before the first frame update
    void Start()
    {
      doorvalue = outsideDoor.GetComponent<DoorValue>();
      Debug.Log(doorvalue.myfloat);

      doorController = outsideDoor.GetComponent<DoorController>();
      Debug.Log(doorController.IsLocked);
     
      thiskey = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
  private void OnTriggerEnter(Collider other) {
       Debug.Log(doorController.IsLocked = false); 

        playSound.Play();
       
      
      

//

     //  outsideDoor.GetComponent<DoorController>();
//Destroy(gameObject);
    }


    private void OnTriggerExit(Collider other){
      Debug.Log("entered");
      Destroy(thiskey);

    }


}
