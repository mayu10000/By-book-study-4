using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nullnulltouchandmove : MonoBehaviour
{


    GameObject GameObjectOne;

    private object touchGameObject;
    private object hit;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        // もしtouchGameObjectがnullなら
        //  一回目のタッチだから　GameObjectを変数に保存

        if (GameObjectOne == null) ;
        GameObjectOne = hit.Collider.GameObject;

　// もしtouchGameObjectがnullなら
  //  二回目のタッチだから
　// touchGameObjectに対して2回目のタッチの場所を
  // touchGameObject.transform.positionに指定　
  // たとえば、りんごをバスケットの位置に移動する
 
　   else　if
        (GameObjectOne != null)
        {
            GameObjectOne.transform.position = touchGameObject.transform.position;

        }


    }
}
