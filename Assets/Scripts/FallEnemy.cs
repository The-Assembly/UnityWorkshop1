using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEnemy : MonoBehaviour
{
    int x = -20;
    int y = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   // static Vector2 startPosition = new Vector2(20, 20);
    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Floor")){
            Debug.Log("wefg");
            other.transform.position = new Vector2(transform.position.x, transform.position.y);//startPosition.transform.position;
            // - 20 20 x
            // y 25  transform.position2D() 
        }
    }

   
}
