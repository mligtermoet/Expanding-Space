using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchadeBalk : MonoBehaviour
{
    [SerializeField]private SchadeRuimte schadeRuimte;
    private float timer;
    
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
            this.gameObject.SetActive(false);
            schadeRuimte.ReadyToFix = true;
        }
    }
}
