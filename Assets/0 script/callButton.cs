using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class callButton : MonoBehaviour
{

    //  public GameObject menuObj;


    bool isArrived = false;

    //  追加　Quit　ボタンのため
    //   public GameObject menuObj;


    //  追加　ボタン　リフトに乗りますか？
    // public GameObject liftObj;

    //    if (other.gameObject.tag == "GoalKusudama")
    //     {
    //         menuObj.SetActive(true);
    //
    //     }


    //  追加　品切れ　ボタンのため
    public GameObject callObj;

    public void CallButton()
    {


        //    if (other.gameObject.tag == "GoalKusudama")
        //     {
        callObj.SetActive(true);

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


            //  if (isArrived) return;

            //  isArrived = true;

        }
    }

