using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap3 : MonoBehaviour
{
   
    //[SerializeField] //inspector상의 myRigid를 채워넣을 수 있게 해줌
    private Rigidbody myRigid;
    private Vector3 rotation;

    void Start(){
        myRigid=GetComponent<Rigidbody>();
        rotation=this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){ // W키를 누르면

            //z축 방향으로 속도가 1로 바뀌어서 앞으로 나가게 됨
            myRigid.velocity = new Vector3(0,0,1);

            //회전속도 조절
            myRigid.angularVelocity = -Vector3.right;

            //질량 조절
            myRigid.mass=2f;

            //저항 조절
            myRigid.drag=2f;

            //회전 저항 조절
            myRigid.angularDrag=2f;

            //회전을 최대속도로 변경시킴
            myRigid.maxAngularVelocity=100;
            myRigid.angularVelocity = Vector3.right*100;

            myRigid.isKinematic=true;

            myRigid.useGravity=true;

            //일정 방향으로 이동시킴,w키를 떼면 멈춤, 관성과 질량의 영향 받지x
            myRigid.MovePosition(transform.forward); 


            //1초에 90도씩 회전 ,w키를 떼면 멈춤, 관성과 질량의 영향 받지x
            rotation+=new Vector3(90,0,0)*Time.deltaTime;
            myRigid.MoveRotation(Quaternion.Euler(rotation));

            //z축 방향으로 1의 세기만큼 힘을 가해서 움직임, 관성과 질량의 영향을 받아서 w키를 떼도 바로 멈추지않고 약간 더 감
            myRigid.AddForce(Vector3.forward);

            //y축 방향으로 돎, 관성과 질량의 영향을 받아서 w키를 떼도 바로 멈추지않음
            myRigid.AddTorque(Vector3.up);

            //폭발 구현할 때 좋음
            myRigid.AddExplosionForce(10,this.transform.right,10); //폭발 세기, 위치, 반경    

            //add시리즈는 물리효과 적용, move 시리즈는 강제적으로 이동시켜 물리효과 미적용        

        }
    }
}
