using UnityEngine;

namespace YEN
{
    /// <summary>
    /// 跑酷遊戲
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
        #region 資料:保存系統需要的資料
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0,35)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0,350)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region 功能:實作該系統的複雜方法

        //
        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            print("跑步中");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);//speedRun之前設定的跑步速度，rig.velocity.y加回角色原來的地心引力設定
        }


        #endregion

        #region 事件:程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            //print("Wellcome to the Running Game!");

            
        }

        private void Update()
        {
            // print("<color=yellow>事件更新中</color>");

            //呼叫方法:方法名稱(對應的引數);
            Run(); //呼叫private void Run
            

        }



        #endregion

    }

}


   

