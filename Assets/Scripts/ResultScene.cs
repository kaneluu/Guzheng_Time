using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultScene : MonoBehaviour
{
    public Button Replay;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {

        Replay = GameObject.Find("Replay").
            GetComponent<Button>();
        Replay.onClick.AddListener(() => CharacterScene("Level1"));
        quit = GameObject.Find("Quit").
            GetComponent<Button>();
        quit.onClick.AddListener(() => Quit());

    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void CharacterScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
