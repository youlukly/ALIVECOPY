using UnityEngine;
using Ultimate;

public class UIActionManager : AliveBehavior
{
    [SerializeField] private Camera uicam;
    private MobileInputHandler handler;
    private InteractiveItem[] items;

    [SerializeField] private InteractiveItem leftTouch;
    [SerializeField] private InteractiveItem rightTouch;

    [SerializeField] private GameObject js;
    [SerializeField] private Transform jsCenter;
    [SerializeField] private Transform jsButton;

    [SerializeField] private GameObject attackpad;
    [SerializeField] private Transform attackCenter;
    [SerializeField] private Transform attackButton;

    [Range(0.0f,200.0f)]
    public float JoystickGap;
    private Vector2 joystickDirection;
    private Vector2 attackStickDirection;

    private readonly Vector2 screenBounds = new Vector2(Screen.width * 0.5f, Screen.height *0.5f);

    private int jsFinger = -1;
    private bool jsStickMoving = false;

    private int attackFinger;
    private bool attackStickMoving = false;

    public void Init()
    {
        Debug.Log("UIActionManager Init Start");

        game.inputManager.Init(new InputManager.MobilePlatform(2,0.1f, uicam));
        handler = game.inputManager.GetHandler<MobileInputHandler>();

        items = FindObjectsOfType<InteractiveItem>();
        foreach (InteractiveItem item in items)
        {
            game.inputManager.SetInput(new Ultimate.Input(item.buttonName));
        }
    }

    public Vector2 GetJoystickDirection()
    {
        return joystickDirection;
    }

    public Vector2 GetAttackstickDirection()
    {
        return attackStickDirection;
    }

    public void AttackDown()
    {
        Debug.Log("AttackDown");
        attackFinger = rightTouch.touchId;
    }

    public void AttackPress()
    {
        JoystickPress(attackCenter, attackButton.transform, attackFinger, ref attackStickMoving, ref attackStickDirection);
    }

    public void AttackUp()
    {
        attackCenter.localPosition = new Vector2(1116, 150);
        attackButton.transform.localPosition = new Vector2(1116, 150);
        attackStickMoving = false;
        //attackStickDirection = Vector2,zero;
;    }

    public void JoystickDown()
    {
        jsFinger = leftTouch.touchId;
    }

    public void JoystickPress()
    {
        JoystickPress(jsCenter, jsButton.transform, jsFinger,ref jsStickMoving,ref joystickDirection);
    }

    public void JoystickUp()
    {
        joystickDirection = Vector2.zero;
        jsCenter.localPosition = new Vector2(150, 150);
        jsButton.transform.localPosition = new Vector2(150, 150);
        jsStickMoving = false;
    }

    private void JoystickPress(Transform center, Transform button, int fingerIndex, ref bool stickMoving, ref Vector2 direction)
    {
        Vector2 delta = new Vector2(center.localPosition.x, center.localPosition.y);
        Vector2 current = handler.GetNowPos(fingerIndex);
        Vector2 target = current;
        float distance = (delta - current).sqrMagnitude;

        if (!stickMoving)
        {
            if (distance > JoystickGap * JoystickGap)
                stickMoving = true;

            Vector2 dir = delta - current;
            direction = -dir;
        }
        else
        {
            if (distance < JoystickGap * JoystickGap)
                stickMoving = false;

            float max = JoystickGap * JoystickGap;
            float interpole = distance / max;
            target = delta - current;

            delta = Vector3.Lerp(delta, current + (target.normalized * JoystickGap), Ultimate.Time.globalDeltaTime * interpole * 10.0f);

            center.localPosition = Vector3.Lerp(center.localPosition, delta, 1.0f);

            direction = -target;
        }

        button.localPosition = Vector3.Lerp(button.localPosition, current, 1.0f);
    }
}
