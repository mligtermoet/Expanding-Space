using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sound : MonoBehaviour
{
    public AudioSource Buttons;
    public AudioSource MainMenu;
    public AudioSource InGameMusic;
    public AudioSource InGameMusic2;
    public AudioSource Mech;
    public AudioSource Astro;
    public AudioSource Water;
    public AudioSource Elec;
    public AudioSource Food;
    public AudioSource Repairing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtons()
    {
        Buttons.Play();
    }

    public void PlayMainMenu()
    {
        MainMenu.Play();
    }

    public void PlayInGameMusic()
    {
        InGameMusic.Play();
    }

    public void PlayInGameMusic2()
    {
        InGameMusic2.Play();
    }



    public void PlayMech()
    {
        Mech.Play();
    }

    public void PlayAstro()
    {
        Astro.Play();
    }

    public void PlayWater()
    {
        Astro.Play();
    }
    public void PlayElec()
    {
        Astro.Play();
    }
    public void PlayFood()
    {
        Astro.Play();
    }
    public void PlayRepairing()
    {
        Repairing.Play();
    }

}
