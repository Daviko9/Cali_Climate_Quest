using UnityEngine;

public class ColisionCubo: MonoBehaviour
{
    public Generador generador; // Referencia al script Generador

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que colisiona tiene el tag "Trash"
        if (other.CompareTag("Trash"))
        {
            // Restar puntos
            if (generador != null)
            {
                generador.RestarPunto();
                Debug.Log("Basura incorrecta. Puntos restados.");
            }
        }
    }
}
