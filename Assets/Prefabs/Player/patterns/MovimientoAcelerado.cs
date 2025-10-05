using UnityEngine;

public class MovimientoAcelerado : iMovementStrategy
{
    private float velocidadActual = 0f; // Velocidad actual del jugador
    private float aceleracion = 2f; // Aceleración del jugador

    public void Move(Transform transform, Player player, float direccion)
    {
        //velocidadActual += Input.GetAxis("Horizontal") * player.Aceleration*Time.deltaTime; // Incrementa la velocidad actual basado en la entrada vertical
        //velocidadActual += direccion * player.Aceleration * Time.deltaTime; // Incrementa la velocidad actual basado en la entrada vertical
        //player.Velocity = Mathf.Clamp(velocidadActual, -player.Velocity, player.Velocity); // Limita la velocidad actual a la velocidad lateral máxima
        float movement = direccion *(player.Velocity+player.Aceleration); // Calcula el movimiento basado en la dirección, velocidad y aceleración
        transform.Translate(movement * Time.deltaTime,0,0); // Mueve el jugador hacia adelante con la velocidad actual
    }
}
