using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneSystem : MonoBehaviour
{
    public Button startButton;
    public Button settingButton;
    public Button quitButton;
    void Start()
    {
        ButtonInit();
    }

    void ButtonInit(){
        startButton.onClick.AddListener(delegate {SceneManager.LoadScene("MainScene");});
        settingButton.onClick.AddListener(delegate {SceneManager.LoadScene("SettingScene");});
        quitButton.onClick.AddListener(delegate {Application.Quit();});
    }
}
