using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset;
    private Quaternion rotacionInicial;

    // Start is called before the first frame update
    void Start()
    {
        rotacionInicial = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        // Solo mueve la c�mara con el tanque, pero no cambia su rotaci�n
        transform.position = objetivo.position + offset;

        // Mantiene la rotaci�n original
        transform.rotation = rotacionInicial;
    }

}
