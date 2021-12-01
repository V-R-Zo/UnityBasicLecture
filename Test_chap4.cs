using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap4 : MonoBehaviour
{
   
    //[SerializeField] 
    private BoxCollider col;

    void Start(){
        col=GetComponent<BoxCollider>();
        
    }

    
    void OnTriggerEnter(Collider other) 
    //istrigger 체크된 상태에서 box collider 안에 다른 콜라이더가 들어왔다면
    {
      
    }
    void OnTriggerExit(Collider other) {
        //나가는 순간 실행

        other.transform.position+=new Vector3(0,2,0); //빠져나가는 순간 움직임

    }

    void OnTriggerStay(Collider other) {
        //머물때(둘이 닿아 있을 때) 실행
        other.transform.position+=new Vector3(0,0,0.1f); //다른 애가 z축으로 0.1씩 이동 
    }

    private void onCollisionEnter(Collision collision){ //istrigger 체크 안됐고 실제 물리적 충돌이 일어났을 때

    }
     private void onCollisionExit(Collision collision){ 

    }
     private void onCollisionStay(Collision collision){ 

    }
}
