using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator playerAni;
    [SerializeField] private float moveSpeed = 7f;

    private bool isMovingForward;
    private bool isMovingRight;
    private bool doubleJump;
    private bool isOnCurve;
    private bool isOnCurve_E;

    private Vector3 respawnPoint;
    private bool respawn;
    private Vector3 deadPoint;

    public bool isOnGround;
    public bool isJumping;
    public bool dead;


    private void Start () {
        isMovingForward = true;
        isMovingRight = false;
        isOnGround = true;
        doubleJump = false;
        isOnCurve = false;
        isOnCurve_E = false;
        rb = GetComponent<Rigidbody>();
        playerAni = GetComponent<Animator>();
        isJumping = false;
        dead = false;

        respawnPoint = new Vector3(67f, 6.8f, 20.5f);
        respawn = false;
    }


    private void Update() {

        Vector2 inputVector = UpdateDirection();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        if (respawn) {
            transform.position = respawnPoint;
            respawn = false;
            moveSpeed = 7f;
        }

        if (dead) {
            transform.position = deadPoint;
        }

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);

        playerAni.SetFloat("moveSpeed", moveSpeed);
    }


    private Vector2 UpdateDirection() {

        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {

            if (isOnCurve || isOnCurve_E) {
                isMovingForward = !isMovingForward;
                respawnPoint = transform.position;
                if (isOnCurve_E) isMovingRight = true;
                if (isOnCurve) isMovingRight = false;
            }

            else if (isOnGround || doubleJump) {
                rb.AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
                isOnGround = false;
                playerAni.SetBool("isOnGround", false);
                doubleJump = !doubleJump;
                isJumping = true;
                playerAni.SetBool("isJumping", true);
            }

        }

        if (isMovingForward) {
            inputVector.x = -1;
        }
        else {
            inputVector.y = 1;

            if (isMovingRight) {
                inputVector.y = -1;
            }
        }

        //inputVector = inputVector.normalized;

        return inputVector;


    }

    private void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.tag == "Ground") {
            isOnGround = true;
            playerAni.SetBool("isOnGround", true);
            doubleJump = false;
            isJumping = false;
            playerAni.SetBool("isJumping", false);

        }

        if (collision.gameObject.name == "Curve") {
            isOnCurve = true;
        }

        if (collision.gameObject.name == "Curve_E") {
            isOnCurve_E = true;
        }


        if (collision.gameObject.tag == "Trap" || collision.gameObject.tag == "CannonBullet") {
            dead = true;
            playerAni.SetBool("dead", true);
            moveSpeed = 0f;

            deadPoint = transform.position;
            StartCoroutine(Dead());

            //playerAni.SetFloat("dyingMode", 0f);
            // 0 -> troncs
            // 1 -> aigua
}
        
    }

    private void OnCollisionExit(Collision collision) {

        if (collision.gameObject.name == "Curve") {
            isOnCurve = false;
        }

        if (collision.gameObject.name == "Curve_E") {
            isOnCurve_E = false;
        }
    }

    IEnumerator Dead() {
        yield return new WaitForSeconds(3f);
        dead = false;
        playerAni.SetBool("dead", false);
        respawn = true;
        //Vector3 vel = rb.velocity;
        //rb.AddForce(-vel);
    }


}