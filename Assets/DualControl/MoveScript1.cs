using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript1 : MonoBehaviour
{
    [Range(0, 50)]
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("W"))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetButton("S"))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (Input.GetButton("A"))
            transform.Translate( -1* speed * Time.deltaTime,0,0);
        if (Input.GetButton("D"))
            transform.Translate(1 * speed * Time.deltaTime,0,0);
    }
}
