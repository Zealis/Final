using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{

    public static int itemValue = 0;
    



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        if (itemValue == 9)
        {
            ScoreScript.itemValue += -1;

        }

    }

}