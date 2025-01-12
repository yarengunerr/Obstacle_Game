using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject GameOverPanel;
    // Start is called before the first frame update
    public void OpenGameOverPanel()
    {
        GameOverPanel.SetActive(true);
    }
}
