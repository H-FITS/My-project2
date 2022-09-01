using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deng : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.GetComponent<Light>().intensity += 1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<Light>().intensity -= 1f;
            // SendMessage("Start");
        }

    }

}
