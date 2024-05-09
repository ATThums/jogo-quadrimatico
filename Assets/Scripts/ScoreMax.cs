using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMax : MonoBehaviour
{
    public static int valorScore = 0;
    public Text MyscoreText;
    public int scoreAtualCena;
    public int scoreMaximoSalvo;
    string nomeCena;
    public static bool clicouNum = false;

    // Start is called before the first frame update
    void Start()
    {
        clicouNum = false;
        scoreAtualCena = 0;
        scoreMaximoSalvo = 0;
        nomeCena = SceneManager.GetActiveScene().name;
        if (PlayerPrefs.HasKey(nomeCena + "score"))
        {
            scoreMaximoSalvo = PlayerPrefs.GetInt(nomeCena + "score");
        }
        //MyscoreText.text = "Score: " + ScoreNum;
        //MyscoreText = GetComponent<Text>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //clicouNum = Calculos.clicou;
        MyscoreText.text = "Score: " + scoreAtualCena;
        Debug.Log("ClicouNum =" + clicouNum);

        if (clicouNum == true)
        {            
            Debug.Log("Entrou");
            EnviarScore();
        }
        clicouNum = false;
    }

    void EnviarScore()
    {
        scoreAtualCena = scoreAtualCena + valorScore;
        Debug.Log("valorScore = " + valorScore);
        ChecarScore();
    }

    void ChecarScore()
    {
        if(scoreAtualCena > scoreMaximoSalvo)
        {
            scoreMaximoSalvo = scoreAtualCena;
            PlayerPrefs.SetInt(nomeCena + "score", scoreMaximoSalvo);
        }
    }

}
