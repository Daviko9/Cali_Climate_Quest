using UnityEngine;

public class TrashControllerOrganico: MonoBehaviour
{
    private GameObject draggedObject;
    private bool isDragging = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Trash"))
            {
                draggedObject = hit.collider.gameObject;
                isDragging = true;
            }
        }

        if (isDragging && Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (draggedObject != null) // Verificar si el objeto aún existe
            {
                draggedObject.transform.position = mousePosition;
            }
        }

        if (isDragging && Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            if (draggedObject != null) // Verificar si el objeto aún existe
            {
                draggedObject = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isDragging && other.CompareTag("Bin"))
        {
            TrashBinOrganico bin = other.GetComponent<TrashBinOrganico>();
            if (bin != null && draggedObject != null) // Verificar si los objetos aún existen
            {
                bin.DropTrash(draggedObject);
                isDragging = false;
                draggedObject = null;
            }
        }
    }
}
