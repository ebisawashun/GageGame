using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MoveButton : MonoBehaviour
{
    [SerializeField] float moveButtonSpeed = 3f;
    private void Start()
    {
        this.transform.DOMove(new Vector3(10f,10f,10f), moveButtonSpeed);
    }
}