
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

        //在unity會出現欄位Mask，不能是空值，所以拉入要設定的物件(ex:面具)
        /* private GameObject Mask;*/
        [SerializeField]
        private GameObject cube;
        [SerializeField]
        private Transform cube2;

        [SerializeField]
        private Transform cube3;

        [SerializeField]
        private SphereCollider sphere;

        [SerializeField]
        private Transform sphere2;

        [SerializeField]
        private Transform capsule;


        [SerializeField]
        private Rigidbody capsule2;


       
        [SerializeField]
        private Camera came;


        [SerializeField]
        private Transform startPoint;//增加起點圖的欄位



        private void Start()
        {

            /* #region 上課
             //非靜態屬性
             //1.取得 非靜態屬性
             //  語法: 欄位名稱.非靜態屬性
             print("面具的啟動狀態:" + Mask.activeInHierarchy);//面具物具(顯示勾)=True;(顯示沒勾)=false;
             print("面具預設圖層" + Mask.layer);

             print("起點的座標" + startPoint.position);


             //2.設定 非靜態屬性
             //  語法:  欄位名稱.非靜態屬性  指定 值;
             //         Mask.activeInHierarchy=false; (activeInHierarchy是唯讀屬性，官方沒寫)

             Mask.tag="Player";//物件-Mask的標籤在執行時變player
             Mask.layer = 4;//物件圖層改變在4:Water
             startPoint.position = new Vector3(0, 5, 0);//更改起點圖的座標

             //3.使用 非靜態方法
             //  語法:  欄位名稱.非靜態方法(對應的引述);

             Mask.SetActive(false);//執行時，物件-面具顯示會變關掉

             #endregion*/

            #region 練習題

            print("攝影機深度" + came.depth);


            print("球體碰撞的半徑" + sphere.radius);

            came.backgroundColor = Random.ColorHSV();

            capsule.localScale = new Vector3(3, 2, 1);





            #endregion


        }




        private void Update()
            {


                #region 上課

                //  startPoint.Translate(0.5f, 0, 0);//物件持續移動x(左右),y(上下),z(深度);x,y,z可以是浮點數;會有穿牆的bug

                #endregion



                #region 練習題

                cube2.RotateAround(sphere.transform.position, Vector3.back, 20 * Time.deltaTime);

                cube3.transform.LookAt(sphere2.transform.position);

                sphere2.RotateAround(sphere2.transform.position, Vector3.up, 20 * Time.deltaTime);






                capsule2.AddForce(new Vector3(0,30,0));

                #endregion
            }



        
    }


}
