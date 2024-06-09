using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SPManager : MonoBehaviour
{
    public Text spText; // UI Text 컴포넌트를 드래그 앤 드롭으로 연결하세요.
    public int SP = 70; // SP 변수 초기값
    private float lastReductionTime; // 마지막 SP 감소 시간

    void Start()
    {
        // 초기 SP 값 설정 및 텍스트 업데이트
        UpdateSPText();
        lastReductionTime = Time.time;
    }

    void Update()
    {
        // 120초마다 SP를 40 감소
        if (Time.time - lastReductionTime >= 3f)
        {
            SP -= 40;
            UpdateSPText();
            lastReductionTime = Time.time; // 마지막 감소 시간 갱신
            
        }
    }
    public void GameOver()
    {
        if (SP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void UpdateSPText()
    {
        spText.text = "안전 점수 : " + SP.ToString();
    }
}
