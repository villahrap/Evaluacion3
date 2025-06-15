using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InputField inputField;
    // Start is called before the first frame update
    public void GuardarNombre()
    {
        string nombreJugador = inputField.text;
        Debug.Log("Nombre del jugador: " + nombreJugador);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
