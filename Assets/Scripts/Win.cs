using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void Update()
    {


        if (ScoreScript.itemValue == 7)
        {

            SceneManager.LoadScene("WinScreenScene");
            ScoreScript.itemValue = 0;


        }
    }
}
