using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
            //LoadNextLevel();
        //}
    }

    public void OnBackToMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    public void OnPlayButton()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void OnHowToPlayButton()
    {
        StartCoroutine(LoadLevel(2));
    }


    public void OnExitButton()
    {
        //game keluar
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        //StartCoroutine(LoadLevel(1));
        //SceneManagement.LoadScene(SceneManagement.GetActiveScene().buildIndex + 1);
    }

    IEnumerator LoadLevel(int nextScene)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load Scene
        SceneManager.LoadScene(nextScene);

    }
}
