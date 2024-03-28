using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPanel : MonoBehaviour
{
    public GameObject canvasLegal;
    public GameObject canvasDos;
    public ButtonManager buttonManager; // Referencia al script ButtonManager

    // M�todo para activar el canvas legal
    public void MostrarCanvasLegal()
    {
        canvasLegal.SetActive(true);
        canvasDos.SetActive(false);
    }

    // M�todo para desactivar el canvas legal
    public void OcultarCanvasLegal()
    {
        canvasLegal.SetActive(false);
        canvasDos.SetActive(true);
       
    }

    public void Botones()
    {
        buttonManager.PrenderBGotones();
    }
}
