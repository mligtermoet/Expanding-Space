using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    public GameObject Panel;
    public Text moneyText;
    public float moneyAmount;
    public float moneyIncreasedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = 0f;
        moneyIncreasedPerSecond = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        moneyText.text = "@   " + (int)moneyAmount;
        moneyAmount += moneyIncreasedPerSecond * Time.deltaTime;

        if (moneyAmount >= 1000)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(true);
        }
    }
}
