using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 3f;
    public float jumpForce = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirecton = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirecton * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
