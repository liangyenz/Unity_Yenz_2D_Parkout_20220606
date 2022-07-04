
using UnityEngine;


namespace Yen
{
/// <summary>
/// 
/// 跳躍功能
/// </summary>
public class SystemJump : MonoBehaviour
{
        #region 資料
        
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;

        private bool clickJump;//增加clickJump欄位，在Debug模式下會顯示
        private bool isGround;

        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;

        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGoroundOffset;

        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);

        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;




        #endregion

        #region 功能:
        private void JumpKey()
        {
            //玩家 按下 空白鍵 就往上跳躍
            //if判斷式語法: if(布林值) {布林值為 True 執行程式}

            if (Input.GetKeyDown(KeyCode.Space))
            {
               // print("跳躍");
                clickJump = true;//unity Debug 執行 在按下空白鍵 clickJump會打勾
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {

            //如果點擊跳躍 並且&& 在地板上
            if (clickJump && isGround)
            {
                
                rig.AddForce(new Vector2(0, heightJump));//AddForce推力，heightJump跳多高
                clickJump = false;
            }
        }



        /// <summary>
        /// 檢查是否碰到地板
        /// </summary>

        private void CheckGround()
        {
            //2D碰撞器=2D物理，覆蓋盒型區域(中心點，尺寸、角度);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGoroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //print("碰到的物件:" + hit.name);

            isGround = hit;
        }


        #endregion

        #region 事件


        //繪製圖示
        //在編輯器內繪製輔助用的線條、形狀或圖片:遊戲內不會出現

        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color = colorCheckGround;



            //2.繪製圖示
            //transform.position當前物件的座標
            Gizmos.DrawCube(transform.position + v3CheckGoroundOffset, v3CheckGroundSize);



        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();


        }

       

        private void Update()
        {

            JumpKey();
            CheckGround();

        }

        private void FixedUpdate()//固定幀數，每次跳的高度才一樣
        {
            JumpForce();
        }



        #endregion
    }

}

