using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  // ‚Â‚¯–Y‚ê‚È‚¢‚æ‚¤‚É‚µ‚Ü‚µ‚å‚¤
public class test : MonoBehaviour
{
    private void Start()
    {
        // (4,0,0)‚É3•b‚©‚¯‚ÄˆÚ“®‚µ‚Ü‚·
        this.transform.DOMove(new Vector3(0f, -3f, 0f), 3f);
    }
}