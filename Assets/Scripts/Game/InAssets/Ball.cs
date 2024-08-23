using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ball;
    private float XSpeed = 2f, YSpeed = 5.66f, Speed = 6f, centerBallX, radiusBallX, centerCollisionX, halfLengthCollisionX;
    private Vector2 direction;

    private void Awake(){
        ball = GetComponent<Rigidbody2D>();
        radiusBallX = GetComponent<CircleCollider2D>().radius;
        direction = new Vector2(1*XSpeed, -1*YSpeed);
    }

    private void Update(){
        ball.velocity = transform.TransformDirection(direction);
    }

    private void OnCollisionEnter2D(Collision2D other){
        centerBallX = GetComponent<Transform>().position.x;
        centerCollisionX = other.gameObject.GetComponent<Transform>().position.x;
        halfLengthCollisionX = other.gameObject.GetComponent<BoxCollider2D>().bounds.extents.x/2;
        if (centerCollisionX-halfLengthCollisionX-radiusBallX <= centerBallX && centerBallX < centerCollisionX+halfLengthCollisionX+radiusBallX){
            direction.y *= -1;
            if (other.gameObject.name == "Pad"){
                sbyte YPosOrNeg = 1;
                if (direction.y < 0) YPosOrNeg = -1;
                float lengthContact = other.GetContact(0).point.x - centerCollisionX;
                direction.x = Mathf.Sin(0.8f*lengthContact/halfLengthCollisionX)*Speed;
                direction.y = Mathf.Cos(0.8f*lengthContact/halfLengthCollisionX)*Speed*YPosOrNeg;
            }
        }
        else{
            direction.x *= -1;
        }
    }
}
