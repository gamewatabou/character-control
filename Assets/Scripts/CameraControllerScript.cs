using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    // プレイヤーオブジェクト
    public GameObject player;

    void Start()
    {
    }

    void Update()
    {
        // プレイヤーの位置を取得
        Vector3 playerPos = this.player.transform.position;
        float znorm = (playerPos.z - 2);
        float ynorm = (playerPos.y + 2f);

        // プレイヤーの位置をカメラに反映
        transform.position = new Vector3(playerPos.x, ynorm, znorm);
    }
}
