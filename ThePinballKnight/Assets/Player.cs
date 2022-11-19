using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mass = 30f;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
        Physics.gravity = new Vector3(0, -300f, 0);
    }
}
