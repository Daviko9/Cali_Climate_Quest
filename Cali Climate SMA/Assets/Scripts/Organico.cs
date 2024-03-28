using UnityEngine;

public class Organico : MonoBehaviour
{
    public string trashType;
    public float velocidadCaida = 2f;
    public float limiteInferior = -10f; // Ajusta este valor según la posición de tu límite inferior en la pantalla

    private void Update()
    {
        // Mover la basura hacia abajo
        transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);

        // Verificar si la basura alcanza el límite inferior y destruirla
        if (transform.position.y <= limiteInferior)
        {
            Destroy(gameObject);
        }
    }

}
