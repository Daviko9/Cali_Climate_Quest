using UnityEngine;

public class TrashBinPlastico : MonoBehaviour
{
    public string trashType;

    public void DropTrash(GameObject trash)
    {
        if (trash.CompareTag("Trash"))
        {
            if (trashType == trash.GetComponent<Plastico>().trashType)
            {
                Destroy(trash);
                Debug.Log("Basura depositada correctamente en el bote de " + trashType);
            }
            else
            {
                Debug.Log("¡Error! Este tipo de basura no va en este bote.");
            }
        }
    }
}
