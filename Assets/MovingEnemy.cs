using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  // つけ忘れないようにしましょう
public class test : MonoBehaviour
{
    private void Start()
    {
        // (4,0,0)に3秒かけて移動します
        this.transform.DOMove(new Vector3(0f, -3f, 0f), 3f);
    }
}