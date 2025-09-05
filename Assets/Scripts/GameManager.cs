using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string gameState; //静的メンバ

    //Startより前に処理される
    void Awake()
    {
        //ゲームの初期状態をplaying
        gameState = "playing";
    }

    void Start()
    {

    }

    void Update()
    {

    }
}