using UnityEngine;

public class WaterController : MonoBehaviour
{
    private GameObject draggedObject;
    private bool isDragging = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Item"))
            {
                draggedObject = hit.collider.gameObject;
                isDragging = true;
            }
        }

        if (isDragging && Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (draggedObject != null) // Verificar si el objeto a�n existe
            {
                draggedObject.transform.position = mousePosition;
            }
        }

        if (isDragging && Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            if (draggedObject != null) // Verificar si el objeto a�n existe
            {
                draggedObject = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isDragging && other.CompareTag("Bin"))
        {
            HeadBin bin = other.GetComponent<HeadBin>();
            if (bin != null && draggedObject != null) // Verificar si los objetos a�n existen
            {
                bin.DropItem(draggedObject);
                isDragging = false;
                draggedObject = null;
                HealthManager health = GameObject.Find("HealthManager").GetComponent<HealthManager>();
                health.Heal(25);
            } else {
                HealthManager health = GameObject.Find("HealthManager").GetComponent<HealthManager>();
                health.TakeDamage(25);
            }
        }
    }
}