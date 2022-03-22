using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisions : MonoBehaviour
{

public float fogValue;
public float fogDensityIncrement;
public string rockName;

public GameObject [] rocks;

    // Start is called before the first frame update
    void Start()
    {
        rocks = GameObject.FindGameObjectsWithTag("rock");
        foreach (GameObject r in rocks)
        { 
            Debug.Log(r.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        fogValue = RenderSettings.fogDensity;

    }


private void OnControllerColliderHit(ControllerColliderHit hit){

if(hit.gameObject.tag == "rock" && hit.gameObject.name != rockName){

Debug.Log(hit.gameObject.name);

RenderSettings.fogDensity += fogDensityIncrement;

rockName = hit.gameObject.name;
}
}}


