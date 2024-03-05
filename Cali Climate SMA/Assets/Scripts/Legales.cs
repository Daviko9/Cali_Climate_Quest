using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legales : MonoBehaviour
{
    public GameObject canvasLegal;

    // M�todo para activar el canvas legal
    public void MostrarCanvasLegal()
    {
        canvasLegal.SetActive(true);
    }

    // M�todo para desactivar el canvas legal
    public void OcultarCanvasLegal()
    {
        canvasLegal.SetActive(false);
    }
}
