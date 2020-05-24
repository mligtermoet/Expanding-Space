using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpener : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
