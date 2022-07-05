using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



namespace Yen
{

    /// <summary>
    /// 管理結束畫面
    /// 過關與失敗
    /// </summary>

public class ManagerFinal : MonoBehaviour
{
        [SerializeField, Header("畫布")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textfinal;
        /// <summary>
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;



        private void Start()
        {
            textfinal.text = stringTitle;
            //MonoBehaviour 類別API可以直接使用名稱呼叫
            InvokeRepeating("FadeIn", 0, 0.2f);

        }
        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            groupfinal.alpha += 0.1f;

            if (groupfinal.alpha >= 1)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }


        //按鈕與程式溝通方式
        //1.定義公開方法
        //2.Button on Click 設定此腳本的公開方法
        public void Quit()
        {
            //print("離開遊戲");
            //只在發布執行檔 電腦與手裝置上有作用
            Application.Quit();
        }

        public void Replay()
        {
            SceneManager.LoadScene(0);//Scenes in Build的場景名稱或數字
        }



    }

}

