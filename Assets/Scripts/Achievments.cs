using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achievments : MonoBehaviour
{
    /// <summary>
    /// ����������.
    /// </summary>
    public int totalMoney;
    [SerializeField] Button firstAch;
    [SerializeField] bool isFirst;
    // Start is called before the first frame update
    void Start()
    {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        if(totalMoney >= 10 && !isFirst) // ������� ��������� ������ �� 10 �����.
        {
            firstAch.interactable = true;
        }
        else
        {
            firstAch.interactable = false;
        }
    }

    public void GetFirst()
    {
        int money = PlayerPrefs.GetInt("money");
        money += 10;
        PlayerPrefs.SetInt("money", money);
        isFirst = true;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0);
    }
    public void ToMenu() // ����������� �� ������� �����.
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
