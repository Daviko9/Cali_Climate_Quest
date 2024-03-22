using UnityEngine;

public class HeadBin : MonoBehaviour
{
    public string itemType;

    public void DropItem(GameObject item)
    {
        if (item.CompareTag("Item"))
        {
            if (itemType == item.GetComponent<Cloth>().itemType)
            {
                Destroy(item);
                Debug.Log("Item usado correctamente en la cabeza");
            }
            else
            {
                Debug.Log("�Error! Este item no es correcto.");
            }
        }
    }
}
