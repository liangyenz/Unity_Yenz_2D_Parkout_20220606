using UnityEngine;

namespace YEN
{
public class APIStatic : MonoBehaviour
{

        /// <summary>
        /// API Stati靜態使用方式
        /// </summary>


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
            print("應用平台"+ Application.isConsolePlatform);


                #endregion
        }

        private void Update()
        {
            #region 學習
            print("int random range" + Random.Range(1, 3));
            #endregion

            #region 練習題
            print("輸入任意鍵" + Input.anyKey);


            #endregion

        }
    }
}

