using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    private float _speed = 0;
    private Vector2 _startPos;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        // 取得滑動長度
        if (Input.GetMouseButtonDown((0))) {
            // 點擊滑鼠時的座標
            this._startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            // 放開滑鼠時的座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this._startPos.x;

            // 把滑動長度轉換成初始速度
            this._speed = swipeLength / 1000.0f;
        }

        transform.Translate(this._speed, 0, 0); // 移動
        this._speed *= 0.98f; // 減速
    }
}