using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // cai nay chi hoat dong khi build game ra thiet bi
        Application.Quit();

        // thoat game khi dang chay editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
