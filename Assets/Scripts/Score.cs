using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Food food))
        {
            _score += 50;
            Debug.Log(_score);
            Destroy(other.gameObject);
        }
        Destroy(other.gameObject);
    }
}
