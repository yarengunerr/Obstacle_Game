using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{

  bool isHit;
  private void Update() {
    if(Input.GetKeyDown(KeyCode.R))
    {
      var activeScene=SceneManager.GetActiveScene();
      
      SceneManager.LoadScene(activeScene.buildIndex);
      Time.timeScale = 1f;
    }
  }

  private void OnCollisionEnter(Collision other)
  {
    //Debug.Log("Bumped Into To Wall !");
    if (other.gameObject.tag == "Player" && !isHit)
    {

      isHit = true;

      GetComponent<MeshRenderer>().material.color = Color.red;
      gameObject.tag = "Hit";
      other.gameObject.GetComponent<PlayerHealth>().TakeDamage();

    }


  }


}
