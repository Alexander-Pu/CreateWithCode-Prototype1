using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField]
    private float _cooldown = 1f;
    private float _offCooldownTimestamp;
    private bool _spawn;

    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && now > _offCooldownTimestamp)
        {
            _offCooldownTimestamp = now + _cooldown;
            _spawn = true;
        }
    }

    private void FixedUpdate() {
        if (_spawn) {
            _spawn = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
