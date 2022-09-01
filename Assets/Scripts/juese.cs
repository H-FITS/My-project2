using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juese : MonoBehaviour
{
    float speed1 = 10f;
    float speed2 = 400f;
    float t = 0f;
    float xia = 0f;
    public bool ground = false;
    RaycastHit hit;

    void Start() { }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && ground)
        {
            xia = 1.5f;
            t = 0;
        }
        if (!ground)
        {
            t += Time.deltaTime;
            xia -= t * 0.05f;
        }
        if (!Input.GetButtonDown("Jump") && ground)
        {
            xia = -1f;
            t = 0;
        }

        Vector3 a = new Vector3(Input.GetAxis("Horizontal"), xia, Input.GetAxis("Vertical"));
        Vector3 temp1 = transform.TransformDirection(a * Time.deltaTime * speed1);
        // Debug.Log(ground);


        CollisionFlags b = GetComponent<CharacterController>().Move(temp1);
        // bool b = GetComponent<CharacterController>().SimpleMove(temp1);

        if ((int)(b & CollisionFlags.CollidedBelow) != 0)
        {
            ground = true;
        }
        else
        {
            ground = false;
        }


        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * speed2, 0);
        transform.GetChild(0).Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * speed2, 0, 0);


        // if (Physics.Raycast(transform.GetChild(0).position, transform.GetChild(0).forward, out hit, 10))
        // {
        //     if (hit.collider.gameObject.tag == "Door")
        //     {
        //         hit.collider.gameObject.GetComponent<chemen>().doorop = true;
        //         hit.collider.gameObject.GetComponent<chemen>().t = 0;
        //     }
        // }

    }

    // void OnControllerColliderHit(ControllerColliderHit hit)
    // {
    //     if (hit.gameObject.tag == "Door")
    //     {
    //         hit.gameObject.GetComponent<chemen>().doorop = true;
    //         hit.collider.gameObject.GetComponent<chemen>().t = 0;
    //     }
    // }
}
