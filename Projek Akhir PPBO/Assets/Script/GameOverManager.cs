using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        /*else if (Input.GetButtonDown("HomeButton"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }*/
    }
}
