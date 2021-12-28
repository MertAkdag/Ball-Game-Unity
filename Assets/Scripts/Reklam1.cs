using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Reklam1 : MonoBehaviour
{
    public string GameID = "GAME ID";
    public string BannerPlacementID = "BannerReklam";
    public bool testModu = true;

    private bool bannerGosterilecek = true;

    void Start()
    {
        // Unity Ads'i kullanıma hazır hale getir
        Advertisement.Initialize(GameID, testModu);
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
    }

    void Update()
    {
        if (bannerGosterilecek)
        {
            // Banner reklam gösterilmeye hazır mı diye kontrol et
            if (Advertisement.IsReady(BannerPlacementID))
            {
                // Banner reklam gösterilmeye hazır, o halde reklamı göster!
                Advertisement.Banner.Show(BannerPlacementID);

                // Banner'ı gösterdik, artık bu if koşulunu kontrol etmemize gerek yok
                bannerGosterilecek = false;
            }
        }

       
    }

    public void BannerGoster()
    {
        bannerGosterilecek = true;
    }

    public void BannerGizle()
    {
        bannerGosterilecek = false;

        // Banner'ı gizle
        Advertisement.Banner.Hide();
    }

}
