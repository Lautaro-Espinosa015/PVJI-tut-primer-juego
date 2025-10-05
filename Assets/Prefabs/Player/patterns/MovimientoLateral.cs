using UnityEngine;

public class MovimientoLateral : iMovementStrategy
{
    
        public void Move(Transform transform, Player player, float direccion)
        {
            //float direccion = Input.GetAxis("Horizontal"); // Obtiene la dirección horizontal del input
        float moveInX = direccion * player.Velocity * Time.deltaTime;
        transform.Translate(moveInX,0,0); // Mueve el jugador lateralmente
        }
    
}
