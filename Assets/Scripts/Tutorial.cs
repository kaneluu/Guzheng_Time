using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Button SkipButton;

    // Start is called before the first frame update
    void Start()
    {
        SkipButton = GameObject.Find("Skip Button").
            GetComponent<Button>();
        SkipButton.onClick.AddListener(() => CharacterScene("Level1"));
    }

    public void CharacterScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
