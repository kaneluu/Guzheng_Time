using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instruction : MonoBehaviour
{
    public Button TutorialButton;
    public Button SkipButton;
    public Button BackButton;
   

    // Start is called before the first frame update
    void Start()
    {
        TutorialButton = GameObject.Find("Tutorial Button").
            GetComponent<Button>();
        TutorialButton.onClick.AddListener(() => CharacterScene("Tutorial"));
        SkipButton = GameObject.Find("Skip Button").
                    GetComponent<Button>();
        SkipButton.onClick.AddListener(() => CharacterScene("Level1"));
        BackButton = GameObject.Find("Main Button").
                    GetComponent<Button>();
        BackButton.onClick.AddListener(() => CharacterScene("Main"));
    }

    public void CharacterScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
