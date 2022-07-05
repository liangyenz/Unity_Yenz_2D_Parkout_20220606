using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



namespace Yen
{

    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary>

public class ManagerFinal : MonoBehaviour
{
        [SerializeField, Header("�e��")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textfinal;
        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string stringTitle;



        private void Start()
        {
            textfinal.text = stringTitle;
            //MonoBehaviour ���OAPI�i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);

        }
        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            groupfinal.alpha += 0.1f;

            if (groupfinal.alpha >= 1)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }


        //���s�P�{�����q�覡
        //1.�w�q���}��k
        //2.Button on Click �]�w���}�������}��k
        public void Quit()
        {
            //print("���}�C��");
            //�u�b�o�������� �q���P��˸m�W���@��
            Application.Quit();
        }

        public void Replay()
        {
            SceneManager.LoadScene(0);//Scenes in Build�������W�٩μƦr
        }



    }

}

