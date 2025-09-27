using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Atributos
    private Vector3 fuerzaPorAplicar;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    #endregion
    #region CicloDeVidaDelScript
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 450f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
}
#endregion Fin CicloDeVidaDelScript