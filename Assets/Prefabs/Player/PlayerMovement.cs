using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Atributos
    private Vector3 fuerzaPorAplicar; // Vector3 que representa la fuerza a aplicar al Rigidbody
    private float tiempoDesdeUltimaFuerza; // float que lleva el tiempo desde la última aplicación de fuerza
    private float intervaloTiempo; // float que representa el intervalo de tiempo entre aplicaciones de fuerza
    #endregion
    #region CicloDeVidaDelScript
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 450f); // Fuerza a aplicar en la dirección Z
        tiempoDesdeUltimaFuerza = 0f; // Inicializa el tiempo desde la última fuerza a 0
        intervaloTiempo = 2f; // Intervalo de tiempo de 2 segundos
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime; // Incrementa el tiempo desde la última fuerza
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo) // Si ha pasado el intervalo de tiempo
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar); // Aplica la fuerza al Rigidbody
            tiempoDesdeUltimaFuerza = 0f; // Reinicia el tiempo desde la última fuerza
        }
    }
}
#endregion Fin CicloDeVidaDelScript