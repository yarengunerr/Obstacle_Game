using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject StartPanel;
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void OnStartButtonClicked()
    {

Debug.Log("start panel bozuk mu");
        StartPanel.SetActive(false);

        Time.timeScale = 1f;
    }


}
