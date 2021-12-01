using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_chap8 : MonoBehaviour
{
    private Animation anim;
    private AnimationClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){ //w키 누르면 
            anim.Play("Cube_2"); //cube2라는 애니메이션 실행
            anim.PlayQueued("Cube_2");// 끝나면 cube2 실행
            anim.Blend("Cube_2"); // 애니메이션 cube1과 2가 섞임
            anim.CrossFade("Cube_2"); //실행하던 것이 자연스럽게 사라지고 2가 실행
            if(!anim.IsPlaying("Cube_2"))
                anim.Play("Cube_2");
            anim.Stop(); //정지
            anim.wrapMode=WrapMode.Loop; //랩모드 변경
            anim.clip=clip;
            anim.animatePhysics=false;


        }
        
    }
}
