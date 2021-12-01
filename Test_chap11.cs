using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_chap11 : MonoBehaviour{

[SerializeField] private Text txt_name;
[SerializeField] private Image img_name;
[SerializeField] private Sprite sprite;

private bool isCoolTime=false;
private float currentTime=5f;
private float delayTime=5f;

void update(){
    img_name.color=Color.red; //색 변화 가능
    // img_name.sprite= 어쩌구 //sprite 변화 가능

    //색 투명하게
    Color color = img_name.color;
    color.a=0f;
    img_name.color=color;

    if(isCoolTime){
        currentTime-=Time.deltaTime;
        img_name.fillAmount=currentTime/delayTime; //버튼이 빙글빙글 돌게됨

        if(currentTime<=0){ //다시 누르면 다시 돌 수 있게
            isCoolTime=false;
            currentTime=delayTime;
            img_name.fillAmount=currentTime;
        }
    }
}


    // Start is called before the first frame update
    public void Change()
    {
        txt_name.text="변경됨";
        isCoolTime=true;
        
    }
    
    
}

    

