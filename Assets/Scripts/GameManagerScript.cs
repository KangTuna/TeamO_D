using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
  
    public Text uiText; // UI Text 컴포넌트를 드래그 앤 드롭으로 연결하세요.

    void Start()
    {
        // 초기 텍스트 설정
        uiText.text = "Initial Text";
    }
    void Update()
    {
        // 매 프레임마다 텍스트 업데이트 (예제: 시간 업데이트)
        uiText.text = "Time : " + Time.time.ToString("F2");

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("끝");
            SceneManager.LoadScene("ObjectiveComplete");
        }
    }
    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnClickNewGame()
    {
        SceneManager.LoadScene("Objective");
    }
    public void OnClickGameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnClickOption()
    {
        SceneManager.LoadScene("Option");
    }
    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
