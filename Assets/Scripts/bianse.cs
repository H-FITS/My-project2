using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bianse : MonoBehaviour
{
    Color a;
    bool b = false;
    void Start()
    {
        a = GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        transform.Rotate(120 * Time.deltaTime, 0, 0);
    }

    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = a;
    }

    void OnMouseDown()
    {
        AudioSource a = GetComponent<AudioSource>();
        if (!b)
        {
            a.Play();
            b = true;
        }
        else
        {
            a.Pause();
            b = false;
        }


        int d = ddd(1, 2);
        int ddd(int a, int b)
        {
            return a + b;
        }

    }
}

public class aaa
{
    public int c;

    public aaa()
    { }
    public aaa(int a, int b)
    {
        c = a + b;
    }
    public void bbb()
    { }
    public int ccc()
    {
        return 0;
    }
    public int ddd(int a, int b)
    {
        return a + b;
    }
}




