namespace P08_Observer.Step2;

public class RegPromotionObserver : IRegObserver
{
    private readonly PromotionService _promotionService;

    public RegPromotionObserver(PromotionService promotionService)
    {
        _promotionService = promotionService;
    }

    public void HandleRegSuccess(long userId)
    {
        _promotionService.IssueNewUserExperienceCash(userId);
    }
}