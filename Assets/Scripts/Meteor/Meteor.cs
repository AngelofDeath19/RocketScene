using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float meteorSpeed = 10f;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.down * meteorSpeed * Time.deltaTime);
    }

}
