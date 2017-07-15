using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private float horizontalMove, verticalMove;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 8.0f; 
        verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 8.0f;

        transform.Translate(horizontalMove, 0, verticalMove);

    }
}
