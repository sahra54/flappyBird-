using UnityEngine;

public class kusScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float ziplamaGucu;
    public MantýkScript mantýk;
    public bool kusYasiyomu=true;
    void Start()
    {
        mantýk = GameObject.FindGameObjectWithTag("Mantýk").GetComponent<MantýkScript>();
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && kusYasiyomu==true)
        {
            rigidbody.linearVelocity = Vector2.up * ziplamaGucu;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mantýk.oyunBitti();
        kusYasiyomu = false;
    }
}
