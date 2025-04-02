using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;


public class UIController : MonoBehaviour
{
    private string readUser;
    void Start()
    {
        string read = MainManager.highScoreUser = File.ReadAllText(Application.dataPath + "/highScore.txt");
        MainManager.highScoreUser = read.Split(":")[0];
        MainManager.highScore = int.Parse(read.Split(":")[1]);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NavigateToGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void EditName(string text)
    {
        MainManager.userName = text;
    }


}
