using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Rb2D;

    // Update is called once per frame
    void Update()
    {
        float Hdirect = Input.GetAxis("Horizontal");
        float Vdirect = Input.GetAxis("Vertical");

        Rb2D.velocity = new Vector2(Hdirect * 100, Vdirect * 100);         //gives the player movement
      
    }
}
