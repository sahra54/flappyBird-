using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MantıkScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int oyuncuSkoru;
    public Text skorYazısı;
    public GameObject OyunBittiEkrani; 

    [ContextMenu("Skor Yükseltme") ]
    public void skorEkle(int scoretoAdd)
    {
        oyuncuSkoru = oyuncuSkoru + scoretoAdd;
        skorYazısı.text = oyuncuSkoru.ToString();
    }

    public void tekrarBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }

    public void oyunBitti()
    {
        OyunBittiEkrani.SetActive(true);
    }
}
