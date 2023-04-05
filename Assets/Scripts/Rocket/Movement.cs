using UnityEngine;

public class Movement : MonoBehaviour
{
    public float translateSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        float translateAxis = Input.GetAxis("Vertical") * translateSpeed;

        transform.Translate(0, 0, translateAxis * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag
        if (collision.gameObject.CompareTag("Meteor"))
        {
            // Do something if the collision involves an enemy
            Destroy(gameObject);
            
            // Increment player score or health, for example
        }
    }
}
