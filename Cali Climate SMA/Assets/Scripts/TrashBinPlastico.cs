using UnityEngine;

public class TrashBinPlastico : MonoBehaviour
{
    public string trashType;
    public Generador generador; // Referencia al script Generador

    public void DropTrash(GameObject trash)
    {
        if (trash.CompareTag("Trash"))
        {
            if (trashType == trash.GetComponent<Plastico>().trashType)
            {
                Destroy(trash);
                generador.SumarPunto(); // Sumar punto
                Debug.Log("Basura depositada correctamente en el bote de " + trashType);
            }
            else
            {
                Destroy(trash);
                generador.RestarPunto(); // Restar punto
                Debug.Log("¡Error! Este tipo de basura no va en este bote.");
            }
        }
    }
}