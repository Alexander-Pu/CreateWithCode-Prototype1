using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectilePrefab;
    [SerializeField]
    private float _playerSpeed = 10f;
    [SerializeField]
    private float _xRange = 10f;
    private float _horizontalInput;
    private bool _shoot;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)) {
            _shoot = true;
        }
    }

    private void FixedUpdate() {
        transform.Translate(Vector3.right * _horizontalInput * _playerSpeed * Time.deltaTime);

        if (transform.position.x > _xRange) {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        } else if (transform.position.x < -_xRange) {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if (_shoot) {
            Instantiate(_projectilePrefab, transform.position, _projectilePrefab.transform.rotation);
            _shoot = false;
        }
    }
}
