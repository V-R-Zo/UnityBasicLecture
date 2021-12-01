using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap9 : MonoBehaviour
{

    private Animator anim;
    private Rigidbody rigid;
    private BoxCollider col;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce; //점프 스피드
    [SerializeField] private LayerMask layerMask;

    private bool isMove;
    private bool isJump;
    private bool isFall;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rigid=GetComponent<Rigidbody>();
        col=GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        TryWalk();
        TryJump();
    }

    private void TryJump(){

        if(isJump){
            if(rigid.velocity.y<=-0.1f&&!isFall){
                isFall=true;
                anim.SetTrigger("Fall");
            }

            RaycastHit hitInfo;
            if(Physics.Raycast(transform.position,-transform.up,out hitInfo,col.bounds.extents.y + 0.1f,layerMask)) 
            //자기 자신의 방향에서 아래 방향으로 레이저를 (박스콜라이더 y값*1/2)+0.1f 만큼 특정 레이어만 반응하게 레이저를 쏨
            {
                anim.SetTrigger("Land");
                isJump=false;
                isFall=false;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)&&!isJump){
            isJump=true; //한번만 실행되게
            rigid.AddForce(Vector3.up * jumpForce);
            anim.SetTrigger("Jump");
        }
    }

    private void TryWalk(){
        float _dirX=Input.GetAxisRaw("Horizontal"); 
        //A,D키 혹은 방향키(오,왼)을 뜻함 오른쪽 키가 눌리면 1이 리턴되고 왼쪽키가 눌리면 -1이 리턴 안눌리면 0리턴
        float _dirZ=Input.GetAxisRaw("Vertical"); 
        //w,s키 혹은 방향키(위,아래)을 뜻함 위키가 눌리면 1 아래키 눌리면 -1 안눌리면 0리턴

        Vector3 direction = new Vector3(_dirX,0,_dirZ);
        isMove=false;
        
        if(direction!=Vector3.zero){

             isMove=true;
            this.transform.Translate(direction.normalized *moveSpeed * Time.deltaTime);
            //대각선 움직임도 수평 수직 움직임과 똑같이 만들기 위해 normalized를 함. 하지 않으면 대각선 속도만 유독 빨라짐.
        }
        anim.SetBool("Move",isMove);
        anim.SetFloat("DirX",direction.x);
        anim.SetFloat("DirZ",direction.z);
    }
}
