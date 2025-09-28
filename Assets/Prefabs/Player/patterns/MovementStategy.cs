using UnityEngine;

public class MovimientoLateral : MovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        float direction = Input.GetAxis("Horizontal"); // Get horizontal input direction
        transform.Translate(direction * speed * Time.deltaTime, 0, 0); // Move the player laterally
    }
}
