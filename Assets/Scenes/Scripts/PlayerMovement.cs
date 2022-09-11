using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 10f;

    private float xInp;
    private float zInp;

    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
    }

    
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        xInp = Input.GetAxis("Horizontal");
        zInp = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(xInp * moveSpeed * Time.deltaTime,0f ,zInp * moveSpeed * Time.deltaTime);
    }
}
