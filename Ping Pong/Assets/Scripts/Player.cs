using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movementSpeed = 100f;

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(0, verticalInput);
        transform.Translate(direction * movementSpeed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x,Mathf.Clamp(transform.position.y, 90f, 410f));
    }
}
