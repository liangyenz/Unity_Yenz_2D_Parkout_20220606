using UnityEngine;

namespace YEN
{
public class APIStatic : MonoBehaviour
{

        /// <summary>
        /// API Stati靜態使用方式
        /// </summary>
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region 學習
            print("隨機值" + Random.value);

            print("PI" + Mathf.PI);
            print("無限大" + Mathf.Infinity);
            Time.timeScale = 0.5f;

            print("float random range" + Random.Range(10f, 30f));
            #endregion

            #region 練習題
            print("camera number is " + Camera.allCamerasCount);
            print("應用平台"+ Application.platform);

            Physics.sleepThreshold = 10;
            print("睡眠臨界值" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("時間大小" + Time.timeScale);

            print("999.99去掉小數點四捨五入"+Mathf.Round(999.99f));

            float distance = Vector3.Distance(a,b);
            print("<color=yellow>距離" + distance + "</color>");

            Application.OpenURL("https://unity.com/");


                #endregion
        }

        private void Update()
        {
            #region 學習
            print("int random range" + Random.Range(1, 3));
            #endregion

            #region 練習題
            //print("輸入任意鍵" + Input.anyKeyDown);
            //print("遊戲經過時間" + Time.timeSinceLevelLoad);
            print("<color=red>是否按下空白鍵" + Input.GetKeyDown(KeyCode.Space)+"</color>");

            #endregion

        }
    }
}

