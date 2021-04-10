using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneButtons : MonoBehaviour
{
    public Button PlayButton;
    public Button QuitButton;


    // Start is called before the first frame update
    void Start()
    {

        PlayButton = GameObject.Find("Play Button").
            GetComponent<Button>();
        PlayButton.onClick.AddListener(() => CharacterScene(1));
        QuitButton = GameObject.Find("Quit Button").
            GetComponent<Button>();
        QuitButton.onClick.AddListener(() => Quit());


    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void CharacterScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
