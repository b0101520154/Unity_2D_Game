﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{    
    // 註解:說明
    //按鈕如何跟程式溝通
    //需要:方法(函數、功能) - 一堆有功能的程式，演算法
    //語法
    //修飾詞 類型 方法名稱() {}
    //私人 private(預設) - 不可被按鈕呼叫
    //公開 pubic - 可以被按鈕呼叫
    //void 無類型
    public void StartGame()
    {
        print("開始遊戲");          //輸出("訊息") - 文字要加雙引號，儀表板Console

        SceneManager.LoadScene("關卡1");   //場景管理.載入場景("名稱")
     //或用SceneManager.LoadScene(1);   //場景管理.載入場景(編號)
    }
    public void QuitGame()
    {
        print("結束遊戲");
        Application.Quit();
    }
}
