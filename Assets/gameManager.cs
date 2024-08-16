using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager INSTANCE;
    void Awake()
    {
        if (INSTANCE != null && INSTANCE != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            INSTANCE = this;
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            changeScene("Game");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            changeScene("Menu");
        }
    }

    void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
