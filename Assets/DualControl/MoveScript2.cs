using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript2 : MonoBehaviour
{
    [Range(0,50)]
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("UP"))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetButton("DOWN"))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if (Input.GetButton("LEFT"))
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        if (Input.GetButton("RIGHT"))
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
}
