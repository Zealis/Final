using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    bool inRange = false;// to be enabled when player is in range of NPC
    bool inChat = false; // to be enabled/Disabled when in/out of chat window
    bool inDialogue1 = true;
    bool inDialogueLeftSubTree = false;
    bool inDialogueUpSubTree = false;


    [Header("Objects")]
    public GameObject npcWindow;
    public Text chatText;
    public Text leftText;
    public Text upText;
    public Text rightText;
    [Header("All Possible Dialogue Options")]
    public string grettings;
    [Header("Dialogue 1")]
    public string left1;
    public string leftResponse1;
    public string up1;
    public string upResonse1;
    public string right1;
    public string rightResponse1;
    [Header("Dialogue 1 LEFT Sub Tree")]
    public string left2;
    public string leftResponse2;
    public string up2;
    public string upResonse2;
    public string right2;
    public string rightResponse2;
    [Header("Dialogue 1 UP Sub Tree")]
    public string left3;
    public string leftResponse3;
    public string up3;
    public string upResonse3;
    public string right3;
    public string rightResponse3;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;   
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Object Entered the trigger");


            Input.GetKeyDown(KeyCode.E);
            inRange = true;
        }
        else
        {
            inRange = false;

            npcWindow.gameObject.SetActive(true);
            chatText.GetComponent<Text>().text = grettings;
            loadDialogue1();
        }
    }
        
    
    void loadDialogue1()
    {
        inChat = true;
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        upText.GetComponent<Text>().text = up1;
        rightText.GetComponent<Text>().text = right1;
    }
    void loadDialogueLeftSubTree()
    {
        
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = left2;
        upText.GetComponent<Text>().text = up2;
        rightText.GetComponent<Text>().text = right2;
    }
    void loadDialogueLeftSubTree2()
    {

        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = "";
        upText.GetComponent<Text>().text = "";
        
    }
    void loadDialogueUpSubTree()
    {

        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = true;
        leftText.GetComponent<Text>().text = left3;
        upText.GetComponent<Text>().text = up3;
        rightText.GetComponent<Text>().text = right3;
    }
    void loadDialogueUpSubTree2()
    {

        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = "";
        upText.GetComponent<Text>().text = "";

    }
    //Buttons
    //Player presses the left button
    public void left()
    {
        if (inDialogue1)
        {
            chatText.GetComponent<Text>().text = leftResponse1;
            loadDialogueLeftSubTree();
        } else if (inDialogueLeftSubTree)
        {
            chatText.GetComponent<Text>().text = leftResponse2;
            loadDialogueLeftSubTree2();
        } else if (inDialogueUpSubTree)
        {
            chatText.GetComponent<Text>().text = leftResponse3;
            loadDialogueUpSubTree2();
        }
    }
    //Player press Up button
    public void up()
    {
        if (inDialogue1)
        {
            chatText.GetComponent<Text>().text = upResonse1;
            loadDialogueUpSubTree();
        } else if (inDialogueLeftSubTree)
        {
            chatText.GetComponent<Text>().text = upResonse2;
            loadDialogueLeftSubTree2();
        } else if (inDialogueUpSubTree)
        {
            chatText.GetComponent<Text>().text = upResonse3;
            loadDialogueUpSubTree2();
        }

    }
    public void right()
    {
        CloseDialogue();
    }
    void CloseDialogue()
    {
        npcWindow.gameObject.SetActive(false);
        inChat = false;
    }


}
