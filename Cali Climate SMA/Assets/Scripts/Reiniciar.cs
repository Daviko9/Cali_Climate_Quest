using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public GameObject canvas;
    public void ReiniciarEscena()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene("Nivel#1");
    }
}