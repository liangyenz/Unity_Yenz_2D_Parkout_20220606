using UnityEngine;

namespace Yen
{
    /// <summary>
    /// �]�ŹC��
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
        #region ���:�O�s�t�λݭn�����
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0,35)]
        private float speedRun = 3.5f;
        
        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region �\��:��@�Өt�Ϊ�������k

        //
        /// <summary>
        /// �]�B�\��
        /// </summary>
        private void Run()
        {
            print("�]�B��");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);//speedRun���e�]�w���]�B�t�סArig.velocity.y�[�^�����Ӫ��a�ߤޤO�]�w
        }


        #endregion

        #region �ƥ�:�{���J�f

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
            // print("<color=yellow>�ƥ��s��</color>");

            //�I�s��k:��k�W��(�������޼�);
            Run(); //�I�sprivate void Run
            

        }


        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            rig.velocity = Vector2.zero;
        }


        #endregion

    }

}


   

