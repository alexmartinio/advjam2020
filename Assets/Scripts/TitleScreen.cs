using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void Start()
    {

        GameObject CrossFade = GameObject.Find("CrossFade");
        CrossFade.SetActive(true);
        CrossFade.GetComponent<Canvas>().enabled = true;

        if (Application.platform != RuntimePlatform.WebGLPlayer)
        {
            GameObject ExitButton = GameObject.Find("ExitButton");
            ExitButton.SetActive(false);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
