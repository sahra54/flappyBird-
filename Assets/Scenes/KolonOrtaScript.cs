using UnityEngine;

public class KolonOrtaScript : MonoBehaviour
{
    public MantýkScript mantýk;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mantýk = GameObject.FindGameObjectWithTag("Mantýk").GetComponent<MantýkScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            mantýk.skorEkle(1);
        }
        
    }
}
