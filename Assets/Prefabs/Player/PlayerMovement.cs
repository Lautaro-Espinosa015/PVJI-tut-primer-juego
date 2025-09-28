using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Atributos
    private Vector3 fuerzaPorAplicar; // Vector3 que representa la fuerza a aplicar al Rigidbody
    private float tiempoDesdeUltimaFuerza; // float que lleva el tiempo desde la última aplicación de fuerza
    private float intervaloTiempo; // float que representa el intervalo de tiempo entre aplicaciones de fuerza
    private float velocidadLateral; // float que representa la velocidad lateral del jugador
    private iMovementStrategy movementStrategy; // Estrategia de movimiento
    #endregion
    #region CicloDeVidaDelScript
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 450f); // Fuerza a aplicar en la dirección Z
        tiempoDesdeUltimaFuerza = 0f; // Inicializa el tiempo desde la última fuerza a 0
        intervaloTiempo = 2f; // Intervalo de tiempo de 2 segundos
        velocidadLateral = 2f; // Velocidad lateral del jugador
        SetMovementStrategy(new MovimientoLateral()); // Establece la estrategia de movimiento a MovimientoLateral
    }

    // Update is called once per frame
    void Update()
    {
        float direccion = Input.GetAxis("Horizontal"); // Obtiene la dirección horizontal del input
        transform.Translate(direccion*velocidadLateral*Time.deltaTime,0,0); // Mueve el jugador lateralmente
        movementStrategy.Move(transform, velocidadLateral); // Llama al método Move de la estrategia de movimiento
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
    #endregion Fin CicloDeVidaDelScript
    #region Logica del Script
    public void SetMovementStrategy(iMovementStrategy strategy)
    {
        movementStrategy = strategy; // Establece la estrategia de movimiento
    }
    #endregion
}
