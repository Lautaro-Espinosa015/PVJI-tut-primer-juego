using UnityEngine;

public class MovimientoAcelerado : iMovementStrategy
{
    private float velocidadActual = 0f; // Velocidad actual del jugador
    private float aceleracion = 2f; // Aceleración del jugador

    public void Move(Transform transform, Player player)
    {
        velocidadActual += Input.GetAxis("Horizontal") * aceleracion*Time.deltaTime; // Incrementa la velocidad actual basado en la entrada vertical
        velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocity, player.Velocity); // Limita la velocidad actual a la velocidad lateral máxima
        transform.Translate(velocidadActual * Time.deltaTime,0,0); // Mueve el jugador hacia adelante con la velocidad actual
    }
}
