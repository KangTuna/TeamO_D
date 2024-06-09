using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
  
    public Text uiText; // UI Text ������Ʈ�� �巡�� �� ������� �����ϼ���.

    void Start()
    {
        // �ʱ� �ؽ�Ʈ ����
        uiText.text = "Initial Text";
    }
    void Update()
    {
        // �� �����Ӹ��� �ؽ�Ʈ ������Ʈ (����: �ð� ������Ʈ)
        uiText.text = "Time : " + Time.time.ToString("F2");

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("��");
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
