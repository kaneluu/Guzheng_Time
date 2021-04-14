using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public string score;

    // Start is called before the first frame update
    [System.Obsolete]
    void Awake()
    {
        if(Application.loadedLevelName == "Level1")
        {
            PlayerPrefs.SetInt("Score", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(score) + "";
    }
}
