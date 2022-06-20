
using UnityEngine;


namespace YEN
{

    /// <summary>
    /// 非靜態API
    /// 與靜態的差別在於需要一個「實體物件」
    /// 「實體物件」一個存在於場景上的遊戲物件Game Object
    /// </summary>

    public class APINonStatic : MonoBehaviour
    {

        [SerializeField]//在unity會出現欄位Mask，不能是空值，所以拉入要設定的物件(ex:面具)
        private GameObject Mask;

        private void Start()
        {
            //非靜態屬性
            //1.取得 非靜態屬性
            //  語法: 欄位名稱.非靜態屬性
            print("面具的啟動狀態:" + Mask.activeInHierarchy);//面具物具(顯示勾)=True;(顯示沒勾)=false;
            print("面具預設圖層" + Mask.layer);


            //2.設定 非靜態屬性
            //  語法:  欄位名稱.非靜態屬性  指定 值;
            //         Mask.activeInHierarchy=false; (activeInHierarchy是唯讀屬性，官方沒寫)

            Mask.tag="Player";//物件-Mask的標籤在執行時變player
            Mask.layer = 4;//物件圖層改變在4:Water


            //3.使用 非靜態方法
            //  語法:  欄位名稱.非靜態方法(對應的引述);

            Mask.SetActive(false);//執行時，物件-面具顯示會變關掉
        }



    }



}
