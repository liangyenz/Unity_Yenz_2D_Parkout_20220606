
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

        [SerializeField]//�bunity�|�X�{���Mask�A����O�ŭȡA�ҥH�ԤJ�n�]�w������(ex:����)
        private GameObject Mask;

        private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o �D�R�A�ݩ�
            //  �y�k: ���W��.�D�R�A�ݩ�
            print("���㪺�Ұʪ��A:" + Mask.activeInHierarchy);//���㪫��(��ܤ�)=True;(��ܨS��)=false;
            print("����w�]�ϼh" + Mask.layer);


            //2.�]�w �D�R�A�ݩ�
            //  �y�k:  ���W��.�D�R�A�ݩ�  ���w ��;
            //         Mask.activeInHierarchy=false; (activeInHierarchy�O��Ū�ݩʡA�x��S�g)

            Mask.tag="Player";//����-Mask�����Ҧb�������player
            Mask.layer = 4;//����ϼh���ܦb4:Water


            //3.�ϥ� �D�R�A��k
            //  �y�k:  ���W��.�D�R�A��k(�������ޭz);

            Mask.SetActive(false);//����ɡA����-������ܷ|������
        }



    }



}
