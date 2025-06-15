using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float moveSpeed = 12f;
    public float strafeSpeed = 12f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;
    private Vector3 inputMovement = Vector3.zero;
    private float inputRotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }


    void Update()
    {
        // Movimiento
        float move = 0f;
        if (Input.GetKey(KeyCode.D)) move = 1f;
        else if (Input.GetKey(KeyCode.A)) move = -1f;

        float strafe = 0f;
        if (Input.GetKey(KeyCode.W)) strafe = -1f;
        else if (Input.GetKey(KeyCode.S)) strafe = 1f;

        inputMovement = transform.forward * move * moveSpeed + transform.right * strafe * strafeSpeed;

        // Rotación
        if (Input.GetKey(KeyCode.Q)) inputRotation = -1f;
        else if (Input.GetKey(KeyCode.E)) inputRotation = 1f;
        else inputRotation = 0f;


        // Movimiento combinado
        Vector3 moveDirection = (transform.forward * move * moveSpeed) + (transform.right * strafe * strafeSpeed);
        transform.Translate(moveDirection * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        // Aplicar movimiento
        rb.velocity = inputMovement;

        // Aplicar rotación suave
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * inputRotation * rotationSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
