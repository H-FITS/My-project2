using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiqu : MonoBehaviour
{
    public static int shuliang = 0;
    public AudioClip a;

    void Start() { }

    void Update() { }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            shuliang++;
            AudioSource.PlayClipAtPoint(a, transform.position);
        }
    }
}
