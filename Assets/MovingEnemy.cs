using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  // ���Y��Ȃ��悤�ɂ��܂��傤
public class test : MonoBehaviour
{
    private void Start()
    {
        // (4,0,0)��3�b�����Ĉړ����܂�
        this.transform.DOMove(new Vector3(0f, -3f, 0f), 3f);
    }
}