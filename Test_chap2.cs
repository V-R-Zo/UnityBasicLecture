using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap2 : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField] // inspector상에 Go_Camera 필드가 생겨 거기에 Main_Camera를 넣어서 go_camera가 private함에도 불구하고 쓰게 해줌
    private GameObject go_camera;

    void Start(){
        rotation=this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){ // W키를 누르면

            //1초에 1씩 Z축으로 움직임
            this.transform.position=this.transform.position+new Vector3(0,0,1);
            //Time.deltaTime은 한프레임 실행하는데 걸리는 시간, 약 60분의 1        
  	        //this.transform.Translate(new Vector3(0,0,1)*Time.deltaTime); 과 같음, 이게 더 편리

            //x축으로 1초에 한번씩 회전
            rotation=rotation+new Vector3(90,0,0)*Time.deltaTime;
            this.transform.eulerAngles=rotation;
            //this.transform.Rotate(new Vector3(90,0,0)*Time.deltaTime); 과 같음, 이게 더 편리
            /*
            rotation=rotation+new Vector3(90,0,0)*Time.deltaTime;
            this.transform.totation=Quaternion.Euler(rotation);
            과 같음
            */

            //1초에 2배씩 크기 커짐
            this.transform.localScale=this.transform.localScale+new Vector3(2,2,2)*Time.deltaTime;

            //카메라를 바라보게 함
            this.transform.LookAt(go_camera.transform.position);

            //큐브가 카메라 주위를 빙빙 돎
            transform.RotateAround(go_camera.transform.position,Vector3.up,100*Time.deltaTime);





        }
    }
}
