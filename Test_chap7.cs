using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   private Light theLight;

   private float targetIntensity;
   private float currentIntensity;

    void Start(){
       theLight = GetComponent<Light>();
       currentIntensity=theLight.intensity;
       targetIntensity=Random.Range(0.4f,1f);
        
    }

    void Update(){
        if(Mathf.Abs(targetIntensity-currentIntensity)>=0.01){
            //목표강도와 현재 강도를 맞추기 (최종 모습: 전구 꺼질랑 말랑 하는듯 깜박거림)
            if(targetIntensity-currentIntensity>=0)
                currentIntensity+=Time.deltaTime*3f;
            else{
                currentIntensity-=Time.deltaTime*3f;
            }

            theLight.intensity=currentIntensity;
            theLight.range=currentIntensity+10;

        }
        else{
            targetIntensity=Random.Range(0.4f,1f);
        }
    }
}

    
    
