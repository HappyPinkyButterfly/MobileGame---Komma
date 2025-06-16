using UnityEngine;


public class TermsAndConditions : MonoBehaviour
{
    public static TermsAndConditions Instance { get; private set; }

    private void Awake()
    {
        // Singleton vzorec (prepreči podvajanje)
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Vedno prikaži dialog ob zagonu igre
        ShowTermsDialog();
    }

    private void ShowTermsDialog()
    {
        // Ustvari dialog BREZ uporabe OnTermOfServiceAccepted
        var dialog = new TermsOfServiceDialog()
            .SetTermsOfServiceLink("https://sites.google.com/view/comalite/domov")
            .SetPrivacyPolicyLink("https://sites.google.com/view/comalite-privacypolicy/domov");

        // Prikaži dialog (brez callbacka)
        SimpleGDPR.ShowDialog(dialog);
    }
}
