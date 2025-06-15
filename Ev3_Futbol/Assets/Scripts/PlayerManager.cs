using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    public InputField inputField;

    public void GuardarNombre()
    {
        string nombreJugador = inputField.text;
        Debug.Log("Nombre del jugador: " + nombreJugador);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
