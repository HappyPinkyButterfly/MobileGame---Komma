using UnityEngine;

public class RuelsExplanation : MonoBehaviour
{
    public ComaLite comaLite { get; set; }

    public void Awake()
    {
        comaLite = GetComponentInParent<ComaLite>();
    }

    public void DestroyRules()
    {
        Destroy(gameObject);
    }

    public void AuctionClick()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Auction");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void CallOfTheWild()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Call");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }

    public void Categories()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Categories");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Detective()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Detective");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void FaceOff()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/FaceOff");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }

    public void GameOf3()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/GameOf3");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Medusa()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Medusa");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Mexican()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Mexican");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }

    public void MostLikely()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/MostLikely");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Never()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Never");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Shiritori()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Shiritori");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }

    public void Would()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Would");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Gambler()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Gambler");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }

    public void Character()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Character");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void Daredevil()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/Daredevil");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    }
    public void RedGreen()
    {
        GameObject auctionRule = Resources.Load<GameObject>("Explanations/RedGreen");
        Instantiate(auctionRule, comaLite.transform.position, comaLite.transform.rotation, comaLite.transform);
    } 
}
