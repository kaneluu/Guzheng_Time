using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instruction : MonoBehaviour
{
    public Button TutorialButton;

    // Start is called before the first frame update
    void Start()
    {
        TutorialButton = GameObject.Find("Tutorial Button").
            GetComponent<Button>();
        TutorialButton.onClick.AddListener(() => CharacterScene(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CharacterScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
