using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArqueroMov : MonoBehaviour
{
    public float speed = 3f;
    private Transform player;

    void Start()
    {
        // Busca al jugador por su tag
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Mover al enemigo hacia el jugador
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí el jugador "pierde"
            Debug.Log("¡Has perdido!");

            // Ejemplo: recargar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
