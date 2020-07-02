using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    private float x;
    private float z;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 100, 0);

    }

    // Update is called once per frame
    void Update()
    {
        z = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {

        rb.MovePosition(transform.position + new Vector3(x, 0f, z) * speed * Time.fixedDeltaTime);
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

    }
}
