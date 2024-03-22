using UnityEngine;

public class BodyBin : MonoBehaviour
{
    public string itemType;

    public void DropItem(GameObject item)
    {
        if (item.CompareTag("Item"))
        {
            if (itemType == item.GetComponent<Ball>().itemType)
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
