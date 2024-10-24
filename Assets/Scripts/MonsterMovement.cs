using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    public Material material;
    private IEnumerator MoveCoroutine;
    private bool moveA = false;
    private bool isRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning == false) {
            StartMoveCoroutine();
            isRunning = true;
        }
        
    }

    private void StartMoveCoroutine()
    {
        if (MoveCoroutine != null)
        {
            //StopCoroutine(MoveCoroutine);
        }
            MoveCoroutine = Move();
            StartCoroutine(MoveCoroutine);

        
    }

    private IEnumerator Move()
    {
        float elapsedTime = 0f;
        float moveTime = 1f;

        if (moveA) {
            while (elapsedTime < moveTime)
            {
                elapsedTime += Time.deltaTime;
                float t = elapsedTime / moveTime;
                Color color = material.color;
                color.r = Mathf.Lerp(0f, 0.1f, t);
                material.color = color;
                material.SetColor("_EmissionColor", color);
                yield return null;
            }
        }
        else {
            while (elapsedTime < moveTime)
            {
                elapsedTime += Time.deltaTime;
                float t = elapsedTime / moveTime;
                Color color = material.color;
                color.r = Mathf.Lerp(0.1f, 0f, t);
                material.color = color;
                material.SetColor("_EmissionColor", color);
                yield return null;
            }
        }
        if (moveA) {
            moveA = false;
        }
        else {
            moveA = true;
        }
        
        isRunning = false;
    }
}
