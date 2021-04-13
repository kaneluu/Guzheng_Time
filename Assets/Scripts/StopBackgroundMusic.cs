using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BackGroundMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
