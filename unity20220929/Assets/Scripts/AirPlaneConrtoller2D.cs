using UnityEngine;

namespace JAY
{
    /// <summary>
    /// ������� 2D �Ҧ�
    /// </summary>
    public class AirPlaneConrtoller2D : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

        private void Update()
        {
            // �W�U WS Vertical
            // ���k AD Horizontal

            // �W W +1
            // �U D -1
            // �S�� 0
            float v = Input.GetAxis("Vertical");
            // �k D +1
            // �� A -1
            // �S�� 0
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);
        }
    }
}
