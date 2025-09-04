using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    float x, y, z; //カメラの座標を決めるための変数

    [Header("カメラの限界値")]
    public float leftLimit;
    public float rightLimit;
    public float bottomLimit;
    public float topLimit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Playerタグをもったゲームオブジェクトを探して、変数playerに代入
        player = GameObject.FindGameObjectWithTag("Player");
        //カメラのZ座標は初期値のままを維持したい
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //いったんプレイヤーのX座標、Y座標の位置を変数に取得
        x = player.transform.position.x;
        y = player.transform.position.y;

        if (x < leftLimit)
        {
            x = leftLimit;
        }
        else if (x > rightLimit)
        {
            x = rightLimit;
        }

        if (y < bottomLimit)
        {
            y = bottomLimit;
        }
        else if (y > topLimit)
        {
            y = topLimit;
        }

        //取り決めた各変数x,y,zの値をカメラのポジションとする
        transform.position = new Vector3(x, y, z);
    }
}
