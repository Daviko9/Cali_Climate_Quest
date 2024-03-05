using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legales : MonoBehaviour
{
    public GameObject canvasLegal;

    // Método para activar el canvas legal
    public void MostrarCanvasLegal()
    {
        canvasLegal.SetActive(true);
    }

    // Método para desactivar el canvas legal
    public void OcultarCanvasLegal()
    {
        canvasLegal.SetActive(false);
    }
}
