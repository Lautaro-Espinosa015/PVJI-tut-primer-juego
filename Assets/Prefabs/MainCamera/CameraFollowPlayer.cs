using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    #region Atributos
    private Vector3 offSet; // Offset entre la cámara y el jugador
    private PlayerMovement player; // Referencia al script PlayerMovement del jugador
    #endregion

    #region ciclo de vida del script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offSet = new Vector3(0, 1, -5); // Offset inicial entre la cámara y el jugador
        player = FindFirstObjectByType<PlayerMovement>(); // Encuentra el primer objeto de tipo PlayerMovement en la escena
    }

    private void LateUpdate()
    {
        gameObject.transform.position = player.transform.position + offSet; // Actualiza la posición de la cámara para seguir al jugador con el offset
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
