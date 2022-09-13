using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportControl : MonoBehaviour
{
    public GameObject player;

    RaycastHit hit;

    public Image img;
    public float fadeTime;
    float curTime;
    Color color;

    bool stopIn = false;
    bool stopOut = false;

    int layerMask;

    Coroutine runningCoroutine = null;

    void Start()
    {
        layerMask = 1 << LayerMask.NameToLayer("BUTTON");
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, layerMask))
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
            {
                hit.transform.GetComponent<Button>()?.onClick.Invoke();
            }
        }
    }

    // 버튼 함수
    public void _OnClickTeleport()
    {
        if (runningCoroutine != null)
        {
            StopCoroutine(FadeEffect(0.0f, 1.0f));
        }
        runningCoroutine = StartCoroutine(FadeEffect(0.0f, 1.0f));

        player.transform.position = hit.transform.position + new Vector3(0, 1.5f, 0);
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

            yield return new WaitForEndOfFrame();
        }

        stopIn = true;
        yield return new WaitUntil(() => stopIn = true);

        curTime = 0.0f;

        while (curTime < fadeTime && stopIn)
        {
            curTime += Time.deltaTime;

            color = img.color;
            color.a = Mathf.Lerp(_end, _start, Mathf.Clamp01(curTime / fadeTime));
            img.color = color;

            yield return new WaitForEndOfFrame();
        }

        stopIn = false;
    }
}
