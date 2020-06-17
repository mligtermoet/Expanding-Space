using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TLevel1 : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene("Tutorial_Level_01");
    }

    public void Load1()
    {
        SceneManager.LoadScene("Tutorial_Level_02");
    }

    public void Load2()
    {
        SceneManager.LoadScene("Tutorial_Level_03");
    }

    public void Load3()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Load4()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
