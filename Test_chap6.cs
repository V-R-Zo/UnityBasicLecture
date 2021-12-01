using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap6 : MonoBehaviour
{
   [SerializeField] 
   private GameObject go_Target;
   [SerializeField] 
   private float speed;

   private Vector3 difValue;

   private MeshRenderer mesh;


    void Start(){
       difValue=transform.position-go_Target.transform.position; //카메라와 물체사이 거리 측정
       difValue=new Vector3(Mathf.Abs(difValue.x),Mathf.Abs(difValue.y),Mathf.Abs(difValue.z)); //절대값으로 변환
        
    }

    void Update(){
        this.transform.position=Vector3.Lerp(this.transform.position,go_Target.transform.position+difValue,speed); // Lerp는 움직임을 보관해줌 -> 중간에 계산해서 이동시킴 , 스피드가 낮아야 부드러운 느낌
    }
}

    
    
