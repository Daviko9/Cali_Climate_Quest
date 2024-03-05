using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1Bueno : MonoBehaviour
{
    public GameObject canvas;
    public void PasaNIvel()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene("Nivel#2");
    }
}
