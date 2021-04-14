using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float DeserdVolueHorizontal;
    public float DeserdVolueVertical;
    //Anahatara basta bir deger ver bu deger ilk itemin degeri olsun ve oyuncu ilk item ile baslayabilsin
    void Start()
    {
        DeserdVolueHorizontal = 3;
        DeserdVolueVertical = 2;
    }
    //Anahtari takip edebilmek icin gelistirme asamasinda anahtar degerleri takip etsin dogru iteme gidip gitmedigine bakabilelim 
    private void Update()
    {
        transform.position = new Vector3(DeserdVolueHorizontal, DeserdVolueVertical, transform.position.z);
    }
}
