using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class reklam : MonoBehaviour
{
    public string GameID = "GAME ID";
    public string InterstitialPlacementID = "Android_Interstitial";
    public bool testModu = true;

    private bool interstitialGosterilecek = false;

    void Start()
    {
        // Unity Ads'i kullanıma hazır hale getir
        Advertisement.Initialize(GameID, testModu);
    }

    void Update()
    {
        if (interstitialGosterilecek)
        {
            // Interstitial reklam gösterilmeye hazır mı diye kontrol et
            if (Advertisement.IsReady(InterstitialPlacementID))
            {
                // Interstitial reklam gösterilmeye hazır, o halde reklamı göster!
                Advertisement.Show(InterstitialPlacementID);

                // Interstitial'ı gösterdik, artık bu if koşulunu kontrol etmemize gerek yok
                interstitialGosterilecek = false;
            }
        }
    }

    

    public void InterstitialGoster()
    {
        interstitialGosterilecek = true;
    }
}
