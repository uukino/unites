using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度

    private Rigidbody rb;

    void Start()
    {
        // Rigidbody コンポーネントを取得
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Rigidbodyがアタッチされていません！");
        }
    }

    void FixedUpdate()
    {
        // 矢印キーの入力を取得
        float moveHorizontal = Input.GetAxis("Horizontal"); // 左右キー
        float moveVertical = Input.GetAxis("Vertical");   // 上下キー

        // 入力に基づいて移動ベクトルを計算
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbodyを使用して球を移動
        rb.AddForce(movement * moveSpeed);
    }
}
