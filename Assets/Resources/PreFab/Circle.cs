using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        CircleCollider2D collider = (CircleCollider2D)this.gameObject.AddComponent<CircleCollider2D>();
        collider.density = 1;
        collider.isTrigger = false;
        collider.enabled = true;


        rigidbody = this.gameObject.AddComponent<Rigidbody2D>();
        rigidbody.bodyType = RigidbodyType2D.Dynamic;
       
        rigidbody.mass = 1;
        rigidbody.useAutoMass = true;
        /*rigidbody.simulated = true;
        
        rigidbody.drag = 0;
        rigidbody.angularDrag = 0.05f;
        rigidbody.gravityScale = 1;
        rigidbody.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        rigidbody.sleepMode = RigidbodySleepMode2D.StartAwake;*/
        rigidbody.sharedMaterial = new PhysicsMaterial2D();
        rigidbody.sharedMaterial.friction = 0.66f;
        rigidbody.sharedMaterial.bounciness = 0.76f;


        Debug.Log("D");
        
        if (Random.Range(0, 20) == 0) {
            rigidbody.bodyType = RigidbodyType2D.Static;
        }
        
        //collider.size.Set(1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Destroy(this.gameObject);
        //Camera  c = (Camera)(FindObjectsOfType(typeof(Camera))[0]);
        //c.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
        //Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(this.transform.position.x, this.transform.position.y, Camera.main.transform.position.z), 0.1f);
        //Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Camera.main.transform.position.z);
        CameraOnLoad col = Camera.main.GetComponent<CameraOnLoad>();
        if (col != null)
        {
            col.track = this.gameObject;
        } 
        //Rigidbody2D rigidbody = (Rigidbody2D)this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(Random.Range(-10000, 10000), Random.Range(-10000, 10000)));
        //Debug.Log("Klikk");
    }    
}
