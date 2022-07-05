
using UnityEngine;


namespace Yen
{
/// <summary>
/// 
/// ���D�\��
/// </summary>
public class SystemJump : MonoBehaviour
{
        #region ���
        
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D����"), Range(0, 3000)]
        private float heightJump = 350;

        

        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;

        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGoroundOffset;

        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);

        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;

        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump = "�}����";//Animator>Parameters���ѼƦW��

        [SerializeField, Header("���D����")]
        private AudioClip soundJump;



        private Animator ani;
        private Rigidbody2D rig;
        private AudioSource aud;

        private bool clickJump;//�W�[clickJump���A�bDebug�Ҧ��U�|���
        private bool isGround;
       




        #endregion

        #region �\��:
        private void JumpKey()
        {
            //���a ���U �ť��� �N���W���D
            //if�P�_���y�k: if(���L��) {���L�Ȭ� True ����{��}

            if (Input.GetKeyDown(KeyCode.Space))
            {
               // print("���D");
                clickJump = true;//unity Debug ���� �b���U�ť��� clickJump�|����
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {

            //�p�G�I�����D �åB&& �b�a�O�W
            if (clickJump && isGround)
            {
                
                rig.AddForce(new Vector2(0, heightJump));//AddForce���O�AheightJump���h��
                clickJump = false;

                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));//���D�ɼ��񭵮�
            }
        }



        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>

        private void CheckGround()
        {
            //2D�I����=2D���z�A�л\�����ϰ�(�����I�A�ؤo�B����);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGoroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //print("�I�쪺����:" + hit.name);

            isGround = hit;
        }

        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);//(!�ۤϰѼ�)!isGround>�PisGround���]�w�ۤ�
        }

        #endregion

        #region �ƥ�


        //ø�s�ϥ�
        //�b�s�边��ø�s���U�Ϊ��u���B�Ϊ��ιϤ�:�C�������|�X�{

        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color = colorCheckGround;



            //2.ø�s�ϥ�
            //transform.position��e���󪺮y��
            Gizmos.DrawCube(transform.position + v3CheckGoroundOffset, v3CheckGroundSize);



        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();


        }

       

        private void Update()
        {

            JumpKey();
            CheckGround();
            UpdateAnimator();

        }

        private void FixedUpdate()//�T�w�V�ơA�C���������פ~�@��
        {
            JumpForce();
        }



        #endregion
    }

}

