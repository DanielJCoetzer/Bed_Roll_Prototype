using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    PlayerInput playerInput;
    Vector2 direction;
    InputAction moveAction;
    private bool isMoving = false;
    private GameObject furniture = null;
    private IEnumerator MoveCoroutine;
    private Vector3 startPos;
    private GameObject lightSwitch;
    public TMP_Text text;


    private float count = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.enabled = false;
        lightSwitch = GameObject.FindGameObjectWithTag("player");
        startPos = transform.position;
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (isMoving == true) {
            count = count -0.1f;
            if (count <= 0) {
                isMoving = false;
                count = 6f;
            }
        }*/
        if (isMoving == false) {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                MovePlayer();
                isMoving = true;            
            }
        }
        /*if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)) {
                isMoving = false;
            }*/
    }

    void MovePlayer()
    {
        direction = moveAction.ReadValue<Vector2>();
        if (direction.x != 0 && direction.y != 0){
            direction.y = 0;
        }
        //transform.position += new Vector3();
        //transform.Translate(direction.x, 0, direction.y);
        StartMoveCoroutine(direction.x, direction.y);
    }

    private void StartMoveCoroutine(float directionX, float directionY = 0)
    {
        if (MoveCoroutine != null)
        {
            //StopCoroutine(MoveCoroutine);
        }
            MoveCoroutine = Move(directionX, directionY);
            StartCoroutine(MoveCoroutine);

        
    }

    private IEnumerator Move(float directionX, float directionY)
    {
        float blockDistance = 1f; // Adjust the block distance as needed
        float elapsedTime = 0f;
        float moveTime = 0.2f;

        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + new Vector3(directionX, 0 , directionY);

        while (elapsedTime < moveTime)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / moveTime;
            transform.position = Vector3.Lerp(startPosition, endPosition, t);
            yield return null;
        }

        transform.position = endPosition;
        isMoving = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bed")) {
            if (lightSwitch.GetComponent<LightSwitch>().lightOn == false) {
                text.enabled = true;
            }
        }
        if (other.CompareTag("Monster")) {
            transform.position = startPos;
        }
        
    }
}
