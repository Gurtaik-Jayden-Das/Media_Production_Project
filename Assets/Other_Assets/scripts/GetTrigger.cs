using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Cube3")
        {
            Debug.Log("It's a hit");
        }
    }
}
