using UnityEngine;

public class TrashBinVidrio : MonoBehaviour
{
    public string trashType;
    public Generador generador; // Referencia al script Generador

    public void DropTrash(GameObject trash)
    {
        if (trash.CompareTag("Trash") && trash.GetComponent<Vidrio>() != null && trashType == trash.GetComponent<Vidrio>().trashType)
        {
            Destroy(trash);
            if (generador != null)
            {
                generador.SumarPunto(); // Sumar punto
                Debug.Log("Basura de vidrio depositada correctamente en el bote de " + trashType);
            }
        }
        else
        {
            Debug.Log("¡Error! Este tipo de basura no va en este bote.");
            if (generador != null)
            {
                generador.RestarPunto(); // Restar punto
            }
        }
    }
}
