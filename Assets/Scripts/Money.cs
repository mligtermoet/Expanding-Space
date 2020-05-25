using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text moneyText;
    public float moneyAmount;
    public float moneyIncreasedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = 0f;
        moneyIncreasedPerSecond = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "@   " + (int)moneyAmount;
        moneyAmount += moneyIncreasedPerSecond * Time.deltaTime;
    }
}
