using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _templates;
    [SerializeField] private float _spawnDelay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            int templateNumber = Random.Range(0, _templates.Length);
            Instantiate(_templates[templateNumber], transform.position, _templates[templateNumber].transform.rotation);
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
