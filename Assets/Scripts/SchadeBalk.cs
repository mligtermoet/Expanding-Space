using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchadeBalk : MonoBehaviour
{
    [SerializeField]private SchadeRuimte schadeRuimte;
    private float timer;
    public AudioSource Repair;
    
    // Start is called before the first frame update
    void Start()
    {
        schadeRuimte = this.gameObject.GetComponentInParent<SchadeRuimte>();
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if(timer >= 3.350f){
            timer = 0;
            Repair.Stop();
            schadeRuimte.ReadyToFix = true;
            schadeRuimte.isRepairing = false;
            this.gameObject.SetActive(false);
            
            
        }
    }
}
