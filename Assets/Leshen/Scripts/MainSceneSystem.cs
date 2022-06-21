using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneSystem : MonoBehaviour
{
    public Button backButton; // 뒤로가기
    public Button guidebookButton; // 도감
    public Button doctorsOfficeButton; // 진료실
    public Button patientsRoomButton; // 입원실
    public AudioSource backgroundMusicSource; // 음악
    public float timestream; // 시간
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        timestream = 0;
        ButtonInit();
    }

    void ButtonInit(){
        backButton.onClick.AddListener(delegate {SceneManager.LoadScene("StartScene");});
        guidebookButton.onClick.AddListener(delegate {SceneManager.LoadScene("GuidebookScene");});
        doctorsOfficeButton.onClick.AddListener(delegate {SceneManager.LoadScene("DoctorsRoomScene");});
        patientsRoomButton.onClick.AddListener(delegate {SceneManager.LoadScene("PatientsRoomScene");});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
