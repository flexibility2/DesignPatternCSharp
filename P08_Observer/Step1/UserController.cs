namespace P08_Observer.Step1;

public class UserController {
    private readonly UserService _userService;
    private readonly PromotionService _promotionService;

    public UserController(UserService userService, PromotionService promotionService)
    {
        _userService = userService;
        _promotionService = promotionService;
    }

    public long Register(string telephone, string password) {
        //省略输入参数的校验代码
        //省略try-catch代码
        long userId = _userService.Register(telephone, password);
        _promotionService.IssueNewUserExperienceCash(userId);
        return userId;
    }
}