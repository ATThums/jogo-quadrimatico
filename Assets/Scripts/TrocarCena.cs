using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrocarCena : MonoBehaviour
{
    public string nomeDaCena;
    // Start is called before the first frame update
    public void ChangeS()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nomeDaCena);
    }

    // Update is called once per frame
    public void Sair()
    {
        Application.Quit();
    }
}