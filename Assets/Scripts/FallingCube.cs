using UnityEngine;

public class FallingCube : MonoBehaviour
{
    public float fallSpeed = 2f;
    public float pillarHeight;  
    public float pillarBaseY;  

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        if (transform.position.y <= pillarBaseY)
        {
            Destroy(gameObject);
        }
    }
}
