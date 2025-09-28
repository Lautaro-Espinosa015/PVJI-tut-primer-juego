using UnityEngine;

public class MovimientoLateral : iMovementStrategy
{
    
        public void Move(Transform transform, Player player)
        {
            float direccion = Input.GetAxis("Horizontal"); // Obtiene la dirección horizontal del input
            transform.Translate(direccion * player.Velocity * Time.deltaTime, 0, 0); // Mueve el jugador lateralmente
        }
    
}
