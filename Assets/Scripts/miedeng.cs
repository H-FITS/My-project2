using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miedeng : MonoBehaviour
{
    public AudioClip a;
    void Start() { }

    void Update()
    {
        Vector3 a = new Vector3(0, 1, 0);
        gameObject.GetComponent<Rigidbody>().velocity = a;
    }

    void OnCollisionEnter()
    {
        GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(a, transform.position);
    }
}
