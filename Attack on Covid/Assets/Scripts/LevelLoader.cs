using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        int sceneID = SceneManager.GetActiveScene().buildIndex;
        if(sceneID == 0 || sceneID == 1 || sceneID == 2 || sceneID == 3){
            SoundController.instance.PlayBGM(BGMType.BGM1);
        }
        if(sceneID == 4){
            SoundController.instance.PlayBGM(BGMType.BGM2);
        }
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

    public void OnHowToPlayButton2()
    {
        StartCoroutine(LoadLevel(3));
    }

    public void OnGameOver()
    {
        StartCoroutine(LoadLevel(4));
    }

    public void OnRetry()
    {
        StartCoroutine(LoadLevel(0));
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
