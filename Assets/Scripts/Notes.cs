using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //The speed of the notes based on the BPM of the song
    Rigidbody2D rBody;
    public float speed;


    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //the velocity component of rigidbody
        //indicate its speed
        rBody.velocity = new Vector2(0, -speed);
    }
}
