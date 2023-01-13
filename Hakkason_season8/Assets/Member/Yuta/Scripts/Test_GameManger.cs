using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameManger : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    private float SpotAngle; //���C�g�̑傫��
    private float time = 0f; //���Ԍo�ߋL�^
    private bool GameOver = false; //�Q�[���I�[�o�[�t���O

    public static bool Item = false; //�A�C�e���擾�t���O
    public static bool But_Item = false;
    public static bool Spot_light = false;

    void Start()
    {
        //�X�|�b�g���C�g�̃R���|�[�l���g�擾
        SpotAngle = lightObject.GetComponent<Light>().spotAngle;
        SpotAngle = 60.0f;  //�����̑傫��
        time = 0f;
        Item = false;
        But_Item = false;
        GameOver = false;
        Spot_light = false;
    }

    void Update()
    {
        //���C�g�̑傫�����f
        lightObject.GetComponent<Light>().spotAngle = SpotAngle;

        time += Time.deltaTime;

        //3�b�o���A�Q�[���I�[�o�[�ł͖���������
        if (time >= 3f && !GameOver)
        {
            //���C�g������������
            SpotAngle -= 1f;
            time = 0f;
        }

        //�A�C�e�����������
        if (Item)
        {
            //���C�g�̑傫���������ɖ߂�
            SpotAngle = 60.0f;
            Item = false;
        }
        if (But_Item)
        {
            SpotAngle -= 5.0f;
            But_Item = false;
        }

        //���C�g�̑傫����20�ȉ���������
        if (SpotAngle < 20f)
        {
            //�_�ł���
            Spot_light = true;
        }
        //���C�g�̑傫����5�ȉ���������
        if (SpotAngle <= 5f)
        {
            //�Q�[���I�[�o�[�ɂ���
            GameOver = true;
            Debug.Log("�I���");
        }

        //L����������
        if (Input.GetKey(KeyCode.L))
        {
            //���C�g�̑傫����20�ɂ���
            SpotAngle = 20.0f;
        }
    }
}
