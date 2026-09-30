using UnityEngine;

public class KolonYapiciScript : MonoBehaviour
{
    public GameObject kolon;
    public float spawnRate = 2;
    private float time = 0;
    public float uzunluk = 5;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate)
        {
            time = time + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            time = 0;
        }

    }

    void SpawnPipe()
    {
        float enYuksek = transform.position.y + uzunluk;
        float enAlcak = transform.position.y - uzunluk;

        Instantiate(kolon, new Vector3(transform.position.x, Random.Range(enAlcak, enYuksek), 0), transform.rotation);
    }
}