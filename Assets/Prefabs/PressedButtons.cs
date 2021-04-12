using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedButtons : MonoBehaviour
{
    SpriteRenderer sRen;
    public KeyCode Key;
    Color old;

    //boolean variable to indicate the trigger
    bool pressed = false;

    //a GameObject variable for our note
    GameObject note;

    void Awake()
    {
        sRen = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sRen.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(Key))
            StartCoroutine(Press());

        if(Input.GetKeyDown(Key) && pressed)
        {
            Destroy(note);
            StartCoroutine(Press());
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if trigger, pressed is true
        pressed = true;
        if (collision.gameObject.tag == "Note")
        {
            note = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        pressed = false;
    }

    IEnumerator Press()
    {
        sRen.color = new Color(0, 1, 1);
        yield return new WaitForSeconds(0.05f);
        sRen.color = old;
    }
}
