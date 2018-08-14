using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float Speed = 1.0f;
    public float JumpSpeed = 30.0f;
    public GameObject BulletPrefab;

    private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            //  spawn a bullet
            GameObject bulletObject = GameObject.Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.D)) {
            //transform.Translate(Vector2.right * Speed *  Time.deltaTime);
            _rigidbody.AddForce(Vector2.right * Speed);
        }

        if (Input.GetKey(KeyCode.W)) {
            //transform.Translate(Vector2.up * Speed * Time.deltaTime);

            Debug.DrawRay(transform.position, Vector2.down, Color.red);
            if (Physics.Raycast(transform.position, Vector2.down, 1.0f)) {
                _rigidbody.AddForce(Vector2.up * JumpSpeed);
            }
        }

        if (Input.GetKey(KeyCode.A)) {
            //transform.Translate(Vector2.left * Speed * Time.deltaTime);
            _rigidbody.AddForce(Vector2.left * Speed);
        }

        if (Input.GetKey(KeyCode.S)) {
            //transform.Translate(Vector2.down * Speed * Time.deltaTime);
            _rigidbody.AddForce(Vector2.down * Speed);
        }
    }
}
