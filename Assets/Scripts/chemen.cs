using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemen : MonoBehaviour
{
    public float t = 0f;
    public bool doorop = false;
    public bool doorop2 = false;

    public AudioClip a;
    public AudioClip b;

    void Start() { }

    void Update()
    {
        if (t > 1)
        {
            doorop = false;
        }
        if (doorop == true)
        {
            if (doorop2 == false)
            {
                transform.parent.GetComponent<Animator>().SetFloat("Float1", 1);
                GetComponent<AudioSource>().PlayOneShot(a);
                // GetComponent<AudioSource>().clip = a;
                // GetComponent<AudioSource>().Play();
                doorop2 = true;
            }
            t += Time.deltaTime;
        }
        if (doorop == false)
        {
            if (doorop2 == true)
            {
                transform.parent.GetComponent<Animator>().SetFloat("Float1", 0);
                GetComponent<AudioSource>().PlayOneShot(b);
            }
            doorop2 = false;
            t = 0;
        }
    }
}
