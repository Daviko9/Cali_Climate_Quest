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
        goodButton.gameObject.SetActive(false); // Desactiva el bot�n malo
        badButton.gameObject.SetActive(false); // Desactiva el bot�n malo
        canvasBueno.SetActive(true);
    }

    void BadButtonClicked()
    {
        goodButton.gameObject.SetActive(false); // Desactiva el bot�n malo
        badButton.gameObject.SetActive(false); // Desactiva el bot�n malo
        canvasMalo.SetActive(true);
    }

    public void PrenderBGotones()
    {
        goodButton.gameObject.SetActive(true); // Desactiva el bot�n malo
        badButton.gameObject.SetActive(true); // Desactiva el bot�n malo

    }
}