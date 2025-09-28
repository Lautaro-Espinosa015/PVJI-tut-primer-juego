using UnityEngine;

public interface iMovementStrategy
{
    public void Move(Transform transform, float velocidadLateral)
    {
        float direccion = Input.GetAxis("Horizontal"); // Obtiene la dirección horizontal del input
        transform.Translate(direccion * velocidadLateral * Time.deltaTime, 0, 0); // Mueve el jugador lateralmente
    }

    }
