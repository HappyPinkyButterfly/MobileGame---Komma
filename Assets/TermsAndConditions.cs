using UnityEngine;


public class TermsAndConditions : MonoBehaviour
{
    public static bool accepted = false;

    private void Awake()
    {
        if (!accepted)
        {
            ShowTermsDialog();
            accepted = true;
        }
    }

    private void ShowTermsDialog()
    {
        var dialog = new TermsOfServiceDialog()
            .SetTermsOfServiceLink("https://sites.google.com/view/comalite/domov")
            .SetPrivacyPolicyLink("https://sites.google.com/view/comalite-privacypolicy/domov");

        SimpleGDPR.ShowDialog(dialog);
    }
}
