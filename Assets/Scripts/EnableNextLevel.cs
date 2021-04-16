using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnableNextLevel : MonoBehaviour
{
    public Button nextLevel;
    public AudioSource music;
    private float duration;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel = GameObject.Find("Next Level").
       GetComponent<Button>();
        nextLevel.interactable = false;
        nextLevel.GetComponent<Image>().color = new Color(1f, 1f, 1f);

        //When the music still plays, the button stays unclickable
        music = GetComponent<AudioSource>();
        duration = music.clip.length;
        StartCoroutine(DelayTime());

    }

    IEnumerator DelayTime()
    {
        music.Play();
        yield return new WaitForSeconds(duration);
        nextLevel.interactable = true;
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if(sceneName == "Level1")
            nextLevel.onClick.AddListener(() => CharacterScene("Level2"));
        else if(sceneName == "Level2")
            nextLevel.onClick.AddListener(() => CharacterScene("Level3"));
        else if(sceneName == "Level3")
            nextLevel.onClick.AddListener(() => CharacterScene("Level4"));
        else if (sceneName == "Level4")
            nextLevel.onClick.AddListener(() => CharacterScene("Result"));
    }
    public void CharacterScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
