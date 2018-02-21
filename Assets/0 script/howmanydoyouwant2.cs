using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



public class howmanydoyouwant2 : MonoBehaviour {


    // 作成するプレハブ(インスペクタから設定）
    public GameObject prefab;

    // InputFieldのインスタンスを格納しておく変数(インスペクタから設定)
    public InputField inputField ;



    void CreateFromInput()
    {
        // 入力した文字列を数字に変更するエラー処理は入れていません
        int createNum = int.Parse(inputField.text);

        for (int i = 0; i < createNum; i++)
        {

            GameObject instance = Instantiate(prefab);

            // ここで生成したい位置があれば設定してください。
        }
    }


    // ボタンが押されたときに呼ばれる
    public void OnClickButton()
    {
        CreateFromInput();
    }




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
