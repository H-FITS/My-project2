using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chemen2 : MonoBehaviour
{
    public bool doorop = false;
    public bool doorop2 = false;

    public AudioClip a;
    public AudioClip b;
    public RawImage c;
    public Texture[] d;
    public Renderer e;
    public Light f;

    void Start()
    {
        Debug.Log("111");
    }

    void Update()
    {
        if (doorop == true)
        {
            if (doorop2 == false)
            {
                transform.GetComponent<Animator>().SetFloat("Float1", 1);
                GetComponent<AudioSource>().PlayOneShot(a);
                doorop2 = true;
            }
        }
        if (doorop == false)
        {
            if (doorop2 == true)
            {
                transform.GetComponent<Animator>().SetFloat("Float1", 0);
                GetComponent<AudioSource>().PlayOneShot(b);
                doorop2 = false;
            }
        }

        if (shiqu.shuliang >= 3)
        {
            f.color = Color.green;
        }
        c.texture = d[shiqu.shuliang];
        e.material.mainTexture = d[shiqu.shuliang];
    }

    void OnTriggerStay(Collider hit)
    {
        Debug.Log(shiqu.shuliang);
        if (hit.gameObject.tag == "Player" && shiqu.shuliang >= 3)
        {
            doorop = true;
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            doorop = false;
        }
    }
}
