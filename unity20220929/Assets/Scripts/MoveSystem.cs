using UnityEngine;

namespace JAY
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            // transform ������ Transform ����
            // translate(x, y, z) �첾
            // Time.deltaTime �C�V�ƪ�O�ɶ�
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
