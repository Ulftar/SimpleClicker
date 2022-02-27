using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// ����������.
    /// </summary>
    [SerializeField] int money;
    public int totalMoney;
    public Text scoreCount;
    /// <summary>
    /// �������� �������� �����.
    /// </summary>
    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        totalMoney = PlayerPrefs.GetInt("totalMoney");
    }
   /// <summary>
   /// �������� ��������� �����, ���������� �������� �����.
   /// </summary>
    public void ButtonClick()
    {
        money++;
        totalMoney++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("totalMoney", totalMoney);
    }
    /// <summary>
    /// ������������ ����� ����������.
    /// </summary>
    public void ToAchievments()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// ����������� �����.
    /// </summary>
    void Update()
    {
        scoreCount.text = money.ToString();
    }
}
