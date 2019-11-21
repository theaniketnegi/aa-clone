using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrow;
    public float speed;
    bool isMouseDown=false;
    public static bool canThrow;

    private void Start()
    {
        canThrow = true;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canThrow)
        {
            isMouseDown = true;
        }
    }
    void FixedUpdate()
    {
        //if (Input.GetMouseButtonDown(0))
        if (isMouseDown)
        { 
                GameObject go=Instantiate(arrow, transform.position,Quaternion.identity);
                go.GetComponent<Rigidbody2D>().AddForce(Vector3.up * speed);
                isMouseDown = false;
        }
    }
}
