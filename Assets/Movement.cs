using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using InControl;

public class Movement : MonoBehaviour
{
    [Header("Basic Element")]
    public GameObject player;
    public GameObject centerEye;
    CharacterController cc;

    float _Horizontal;
    float _Vertical;
    float _Yaw;

    Vector3 direction;
    Vector3 movement;

    [Space(15)]
    [Header("Player Move Element")]
    public float interpolation = 4;
    private float currentH = 0;
    private float currentV = 0;

    public float m_Speed = 2f;
    public float m_LerpSpeed = 3f;

    [Space(15)]
    [Header("Recenter Element")]
    public bool isAngleRecenter = true;
    public float m_OriginAngle = 0f;

    [Space(15)]
    [Header("Fade Effect Element")]
    public Text txt;
    public Image img;
    public float fadeTime;
    float curTime;
    float currenttime;

    [Space(15)]
    [Header("Damaged Screen")]
    public Image damageScreen;

    Color color;
    Color txtColor;

    bool stopIn;
    bool isCheck;

    Coroutine runningCoroutine = null;

    public float _lower = 0;
    public float _upper = 1;

    bool IsActiveControl()
    {
        return (Input.GetJoystickNames().Length > 0);
    }
    float getHorizontal()
    {
        return (InputManager.ActiveDevice.GetControl(InputControlType.Analog5).Value);
    }
    float getVertical()
    {
        return (InputManager.ActiveDevice.GetControl(InputControlType.Analog4).Value);
    }
    float getRotate()
    {
        return (InputManager.ActiveDevice.GetControl(InputControlType.Analog1).Value);
    }

    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Start()
    {
        stopIn = false;
        isCheck = false;

        currenttime = 0;
    }

    void Update()
    {
        Debug.Log(_Vertical);
        Debug.Log(_Horizontal);

        InputDevice inputDevice = InputManager.ActiveDevice;
        if (inputDevice == null)
        {
            return;
        }

        InputManager.ActiveDevice.GetControl(InputControlType.Analog1).LowerDeadZone = _lower;
        InputManager.ActiveDevice.GetControl(InputControlType.Analog1).UpperDeadZone = _upper;

        // Valeg Input Get Value
        _Vertical = getVertical();
        _Horizontal = getHorizontal();
        _Yaw = getRotate();

        // First Move Then Do Recenter - This is for Coroutine Just Once
        // isCheck is for Do Not This Method after First Time
        if (movement != Vector3.zero && !isCheck)
        {
            // if Coroutine is running, return
            if (runningCoroutine != null)
            {
                return;
            }
            cc.enabled = false;
            runningCoroutine = StartCoroutine(FadeEffect(0.0f, 1.0f));
        }

        // if CharacterController is enabled, return;
        if (cc.enabled == false)
        {
            return;
        }

        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            m_OriginAngle = centerEye.transform.eulerAngles.y - (_Yaw * 180);
            transform.localEulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);
        }
        if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.Touch))
        {
            currenttime += Time.deltaTime;
            
            if (currenttime > 2f)
            {
                currenttime = 0f;

                //다시 로비로 돌아가기
                SceneManager.LoadScene(0);
            }
        }

        PlayerMove();
        PlayerRotate();
    }
    void LateUpdate()
    {
        player.transform.position = transform.position + new Vector3(0, 1.3f, 0);
    }

    void PlayerMove()
    {
        currentH = Mathf.Lerp(currentH, _Horizontal, Time.deltaTime * interpolation);
        currentV = Mathf.Lerp(currentV, _Vertical, Time.deltaTime * interpolation);
        direction = new Vector3(currentH * 0.7f, 0, -currentV);
        movement = Vector3.Lerp(Vector3.zero, direction, 1);
        cc.Move(transform.TransformDirection(movement) * m_Speed * Time.deltaTime);
    }
    void PlayerRotate()
    {
        if (IsActiveControl())
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.LerpAngle(transform.eulerAngles.y, m_OriginAngle + _Yaw * 180f, Time.deltaTime * m_LerpSpeed * 5), transform.eulerAngles.z);
        }
        else
        {
            m_OriginAngle = transform.eulerAngles.y;
        }
    }

    IEnumerator FadeEffect(float _start, float _end)
    {
        curTime = 0.0f;
        while (curTime < fadeTime && !stopIn)
        {
            curTime += Time.deltaTime;

            color = img.color;
            color.a = Mathf.Lerp(_start, _end, Mathf.Clamp01(curTime / fadeTime));
            img.color = color;

            txtColor = txt.color;
            txtColor.a = Mathf.Lerp(_start, _end, Mathf.Clamp01(curTime / 1));
            txt.color = txtColor;

            yield return new WaitForEndOfFrame();
        }
        stopIn = true;
        yield return new WaitUntil(() => stopIn = true);

        DoRecenter();

        curTime = 0.0f;
        while (curTime < fadeTime && stopIn)
        {
            curTime += Time.deltaTime;

            color = img.color;
            color.a = Mathf.Lerp(_end, _start, Mathf.Clamp01(curTime / fadeTime));
            img.color = color;

            txtColor = txt.color;
            txtColor.a = Mathf.Lerp(_end, _start, Mathf.Clamp01(curTime / 1));
            txt.color = txtColor;

            yield return new WaitForEndOfFrame();
        }
        stopIn = false;

        isCheck = true;
        cc.enabled = true;

        yield break;
    }

    void DoRecenter()
    {
        m_OriginAngle = centerEye.transform.eulerAngles.y - (_Yaw * 180);
        transform.localEulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);

        var distanceDiff = centerEye.transform.position - transform.position;
        transform.position += new Vector3(distanceDiff.x, 0, distanceDiff.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RHAND"))
        {
            damageScreen.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RHAND"))
        {
            damageScreen.enabled = false;
        }
    }
}
