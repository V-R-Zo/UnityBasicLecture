using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap5 : MonoBehaviour
{
   [SerializeField] 
   private Material red_Mat;
   [SerializeField] 
   private Material green_Mat;

   private MeshRenderer mesh;


    void Start(){
        mesh=GetComponent<MeshRenderer>();
        
    }

    void Update(){
        if(Input.GetMouseButton(0)){ //마우스 클릭시 색이 초록
            mesh.material=green_Mat;
        }

        else{ // 색이 빨강
            mesh.material=red_Mat; 
        }
    }
}

    
    
