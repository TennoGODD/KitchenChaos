

using KitchenChaos.Players;
using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float speedRotaion = 20f;
    [SerializeField] private GameInput gameInput;
    private void Start() {
        
    }
    private void Update() {
        Vector2 inputVector = gameInput.GetMovement();

        Vector3 moveDir = new Vector3(inputVector.x,0f,inputVector.y);
        float moveDistance = speed * Time.deltaTime;
        float playerRadius = 0.7f;
        float playerHeight = 2f;
        bool canMove = !Physics.CapsuleCast(transform.position,transform.position + Vector3.up * playerHeight,playerRadius,moveDir,moveDistance);
        if (canMove)
            transform.position += moveDir * Time.deltaTime * speed;

        transform.forward = Vector3.Slerp(transform.forward,moveDir,Time.deltaTime*speedRotaion); 
    }

    
}
