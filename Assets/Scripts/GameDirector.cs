using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 使用 UI 物件，必須新增此處理程式

public class GameDirector : MonoBehaviour {
    private GameObject _car;
    private GameObject _flag;
    private GameObject _distance;

    // Start is called before the first frame update
    void Start() {
        this._car = GameObject.Find("car");
        this._flag = GameObject.Find("flag");
        this._distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update() {
        float length = this._flag.transform.position.x - this._car.transform.position.x;

        if (length >= 0) {
            this._distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + " m";
        }
        else {
            this._distance.GetComponent<Text>().text = "抵達終點！";
        }
    }
}