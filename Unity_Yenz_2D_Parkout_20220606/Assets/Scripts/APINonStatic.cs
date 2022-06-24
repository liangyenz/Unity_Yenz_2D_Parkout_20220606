
using UnityEngine;


namespace YEN
{

    /// <summary>
    /// �D�R�AAPI
    /// �P�R�A���t�O�b��ݭn�@�ӡu���骫��v
    /// �u���骫��v�@�Ӧs�b������W���C������Game Object
    /// </summary>

    public class APINonStatic : MonoBehaviour
    {

        //�bunity�|�X�{���Mask�A����O�ŭȡA�ҥH�ԤJ�n�]�w������(ex:����)
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
        private Transform startPoint;//�W�[�_�I�Ϫ����



        private void Start()
        {

            /* #region �W��
             //�D�R�A�ݩ�
             //1.���o �D�R�A�ݩ�
             //  �y�k: ���W��.�D�R�A�ݩ�
             print("���㪺�Ұʪ��A:" + Mask.activeInHierarchy);//���㪫��(��ܤ�)=True;(��ܨS��)=false;
             print("����w�]�ϼh" + Mask.layer);

             print("�_�I���y��" + startPoint.position);


             //2.�]�w �D�R�A�ݩ�
             //  �y�k:  ���W��.�D�R�A�ݩ�  ���w ��;
             //         Mask.activeInHierarchy=false; (activeInHierarchy�O��Ū�ݩʡA�x��S�g)

             Mask.tag="Player";//����-Mask�����Ҧb�������player
             Mask.layer = 4;//����ϼh���ܦb4:Water
             startPoint.position = new Vector3(0, 5, 0);//���_�I�Ϫ��y��

             //3.�ϥ� �D�R�A��k
             //  �y�k:  ���W��.�D�R�A��k(�������ޭz);

             Mask.SetActive(false);//����ɡA����-������ܷ|������

             #endregion*/

            #region �m���D

            print("��v���`��" + came.depth);


            print("�y��I�����b�|" + sphere.radius);

            came.backgroundColor = Random.ColorHSV();

            capsule.localScale = new Vector3(3, 2, 1);





            #endregion


        }




        private void Update()
            {


                #region �W��

                //  startPoint.Translate(0.5f, 0, 0);//������򲾰�x(���k),y(�W�U),z(�`��);x,y,z�i�H�O�B�I��;�|������bug

                #endregion



                #region �m���D

                cube2.RotateAround(sphere.transform.position, Vector3.back, 20 * Time.deltaTime);

                cube3.transform.LookAt(sphere2.transform.position);

                sphere2.RotateAround(sphere2.transform.position, Vector3.up, 20 * Time.deltaTime);






                capsule2.AddForce(new Vector3(0,30,0));

                #endregion
            }



        
    }


}
