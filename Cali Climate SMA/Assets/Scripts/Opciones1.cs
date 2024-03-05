using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button goodButton;
    public Button badButton;
    public GameObject canvasMalo;
    public GameObject canvasBueno;

    void Start()
    {
        goodButton.onClick.AddListener(GoodButtonClicked);
        badButton.onClick.AddListener(BadButtonClicked);
    }

    void GoodButtonClicked()
    {
        goodButton.image.color = Color.green;
        badButton.interactable = false;
        canvasBueno.SetActive(true);
    }

    void BadButtonClicked()
    {
        badButton.image.color = Color.red;
        goodButton.interactable = false;
        canvasMalo.SetActive(true);
    }
}