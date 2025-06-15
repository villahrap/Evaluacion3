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
        // Solo mueve la cámara con el tanque, pero no cambia su rotación
        transform.position = objetivo.position + offset;

        // Mantiene la rotación original
        transform.rotation = rotacionInicial;
    }

}
