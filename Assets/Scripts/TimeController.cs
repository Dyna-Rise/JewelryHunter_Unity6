using UnityEngine;

public class TimeController : MonoBehaviour
{
    //カウントダウンにするかどうかのフラグ
    //falseならカウントアップ
    public bool isCountDown = true;

    //ゲームの基準となる時間
    public float gameTime = 0;

    //カウントを止めるかどうかのフラグ
    //falseならカウントし続ける、trueならカウント終了
    public bool isTimeOver = false;

    //ユーザーに見せる時間
    public float displayTime = 0;

    //ゲームの経過時間
    float times = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
