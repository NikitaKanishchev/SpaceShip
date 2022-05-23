using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] private float _tumble = 0.25f;

    private void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * _tumble;
    }
}