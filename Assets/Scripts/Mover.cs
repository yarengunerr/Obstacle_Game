using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /*
    // There variables change our movement speed
    [SerializeField] float xValue=0;
    [SerializeField] float yValue=0.02f;
     [SerializeField] float zValue=0;
    */

    // Start is called before the first frame update

    
   [SerializeField] float moveSpeed=10f;

    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To The Game");
        Debug.Log("Move Your Player With WASD or Arrow Keys");
        Debug.Log("Don't Hit The Walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

    






}

