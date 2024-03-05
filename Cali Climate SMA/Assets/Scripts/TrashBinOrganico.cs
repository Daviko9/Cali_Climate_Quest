using UnityEngine;

public class TrashBinOrganico : MonoBehaviour
{
    public string trashType;

    public void DropTrash(GameObject trash)
    {
        if (trash.CompareTag("Trash"))
        {
            if (trashType == trash.GetComponent<Organico>().trashType)
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
