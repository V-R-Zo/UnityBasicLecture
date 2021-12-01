using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ps.Play(); //실행
        ps.Stop();
        ps.Pause();
        ps.Emit(100); //입자가 순간적으로 100개 뿜어져나옴

        
    }
}
