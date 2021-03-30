using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class PlayerController : MonoBehaviour {
  public PlayerInput playerInput;
  public Rigidbody rb;


  public float speed = 10;

  Vector2 direction;
  Vector3 movement;

  public void OnMovement(InputAction.CallbackContext value) {
    direction = value.ReadValue<Vector2>();
    movement = new Vector3(direction.x, 0, direction.y);
  }

  public void OnAttack(InputAction.CallbackContext value) {
    if (value.started) {
      rb.velocity = movement * speed;
    }
  }

  private void Bounce() {
    rb.velocity = -rb.velocity;
  }

  private void OnCollisionEnter(Collision other) {

  }

  void FixedUpdate() {
  }
}
