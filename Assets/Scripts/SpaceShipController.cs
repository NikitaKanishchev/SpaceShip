using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _shipRigidbody;
    
    
    private void Start()
    {
        _shipRigidbody = GetComponent<Rigidbody>();
    }
    

    
     private void Update()
     {
         SpaceShipMove();
     }

     private void SpaceShipMove()
     {
         var inputY = Input.GetAxis("Horizontal");
         var inputX = Input.GetAxis("Vertical");

         Vector3 shipMove = new Vector3(-inputX, 0, inputY);
         shipMove = shipMove.normalized * (_speed * Time.deltaTime);

         _shipRigidbody.MovePosition(transform.position + shipMove);
     }

}