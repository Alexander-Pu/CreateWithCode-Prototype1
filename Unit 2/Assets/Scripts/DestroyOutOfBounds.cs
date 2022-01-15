using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField]
    private float _upperBound = 30f;
    [SerializeField]
    private float _lowerBound = -10f;

    private void FixedUpdate() {
        if (transform.position.z > _upperBound) {
            Destroy(gameObject);
        } else if (transform.position.z < _lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
