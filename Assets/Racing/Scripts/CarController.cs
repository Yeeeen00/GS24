using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [Header("Car settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20;

    // 지역변수
    float acclerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;

    float velocityVsUp = 0;

    //컴포넌트
    Rigidbody2D carRigidbody2D;

    //Awake
    private void Awake()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ApplyEngineForce();

        KillorthongonalVelocity();

        ApplySteering();
    }

    void ApplyEngineForce()
    {

        velocityVsUp = Vector2.Dot(transform.up, carRigidbody2D.velocity);

        if (velocityVsUp > maxSpeed && acclerationInput > 0)
            return;

        if (velocityVsUp < maxSpeed * 0.5f && acclerationInput < 0)
            return;

        if (carRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && maxSpeed * acclerationInput > 0)
            return;

        // 엑셀을 누르지 않으면 속도가 느려짐
        if (acclerationInput == 0)
        {
            carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 2.0f, Time.fixedDeltaTime * 1);
        }
        else carRigidbody2D.drag = 0;
        //엔진 힘
        Vector2 engineForceVector = transform.up * acclerationInput * accelerationFactor;

        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteering()
    {
        // 속도가 느릴 때 회전 제한
        float minSpeedForAllowTurningFactor = (carRigidbody2D.velocity.magnitude / 6);
        minSpeedForAllowTurningFactor = Mathf.Clamp01(minSpeedForAllowTurningFactor);

        // 회전 연산
        rotationAngle -= steeringInput * turnFactor * minSpeedForAllowTurningFactor;

        // 회전
        carRigidbody2D.MoveRotation(rotationAngle);
    }


    void KillorthongonalVelocity()
    {
        //드리프트
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);
        //연산
        carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        acclerationInput = inputVector.y;
    }



}
