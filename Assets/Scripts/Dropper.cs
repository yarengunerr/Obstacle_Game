using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer; 
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;


    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        GetComponent<Rigidbody>().useGravity = false;

        Invoke(nameof(Init), timeToWait);
    }

    private void Init(){
        renderer.enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
