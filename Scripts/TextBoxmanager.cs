using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxmanager : MonoBehaviour {

    public GameObject textBox;

    public Text theTxt;



    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public PlayerControler player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerControler>();

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

    }

    void Update()
    {
        theTxt.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Z))
        {
            currentLine += 1;
        }

        if(currentLine > endAtLine)
        {
            textBox.SetActive(false);
        }
    }
}
