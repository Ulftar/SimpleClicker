using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Переменные.
    /// </summary>
    [SerializeField] int money;
    public int totalMoney;
    public Text scoreCount;
    /// <summary>
    /// Загрузка значения очков.
    /// </summary>
    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        totalMoney = PlayerPrefs.GetInt("totalMoney");
    }
   /// <summary>
   /// Линейный инкремент очков, сохранение значения очков.
   /// </summary>
    public void ButtonClick()
    {
        money++;
        totalMoney++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("totalMoney", totalMoney);
    }
    /// <summary>
    /// Переключение сцены достижений.
    /// </summary>
    public void ToAchievments()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Отображение очков.
    /// </summary>
    void Update()
    {
        scoreCount.text = money.ToString();
    }
}
