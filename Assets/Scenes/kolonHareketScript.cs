using UnityEngine;

public class kolonHareketScript : MonoBehaviour
{
    public float hareketHizi = 5;
    public float oluAlan = -16;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * hareketHizi) * Time.deltaTime;

        if (transform.position.x < oluAlan) {
            Destroy(gameObject);        
        }
    }
}
