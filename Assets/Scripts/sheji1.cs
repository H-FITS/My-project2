using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sheji1 : MonoBehaviour
{

    // float speed1 = 50f;
    // float speed2 = 500f;
    public GameObject newobject;
    public int sedan = 0;
    public int xms = 0;


    void Start() { }

    void Update()
    {
        // float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed1;
        // float y = Input.GetAxis("Jump") * Time.deltaTime * speed1;
        // float z = Input.GetAxis("Vertical") * Time.deltaTime * speed1;
        // transform.Translate(x, y, z);

        // float a = Input.GetAxis("Mouse Y") * Time.deltaTime * speed2;
        // float b = Input.GetAxis("Mouse X") * Time.deltaTime * speed2;
        // transform.Rotate(-a, b, 0);

        // // if (Input.GetKey(KeyCode.Q))
        // // {
        // //     transform.Rotate(0, -speed2 * Time.deltaTime, 0, Space.Self);
        // // }
        // // if (Input.GetKey(KeyCode.E))
        // // {
        // //     transform.Rotate(0, speed2 * Time.deltaTime, 0, Space.Self);
        // // }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject n = Instantiate(newobject, transform.position, transform.rotation);
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            n.GetComponent<Rigidbody>().AddForce(fwd * 5000);

            sedan++;
            GameObject.Find("Canvas/Test").GetComponent<TextMeshProUGUI>().text = "发射数：" + sedan;
        }
    }
}
