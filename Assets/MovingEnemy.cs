using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovingEnemy : MonoBehaviour
{
    [SerializeField]float moveSpeed = 3f;
    private void Start()
    {
        this.transform.DOMove(new Vector3(0f, -2f, 0f), moveSpeed);
    }
}