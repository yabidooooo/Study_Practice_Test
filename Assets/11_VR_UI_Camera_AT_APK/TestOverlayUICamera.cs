using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestOverlayUICamera : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject rightHand;
    public GameObject mainCamera;
    public GameObject uiCamera;
    public GameObject uiCanvas;
    public OVROverlay cameraRenderOverlay;

    void Start()
    {
        // Start with Overlay Cylinder
        CameraAndRenderTargetSetup();
        cameraRenderOverlay.enabled = true;
        cameraRenderOverlay.currentOverlayShape = OVROverlay.OverlayShape.Cylinder;
    }

    void Update()
    {
        if (Physics.Raycast(rightHand.transform.position, rightHand.transform.forward, out hit, 6, 1 << LayerMask.NameToLayer("TEST")))
        {
            if ( OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
            {
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            _OnClickButton();
        }
    }

    public void _OnClickButton()
    {
        uiCanvas.SetActive(true);
    }

    /// <summary>
    /// Usage: Recreate UI render target according overlay type and overlay size
    /// </summary>
    void CameraAndRenderTargetSetup()
    {
        float overlayWidth = cameraRenderOverlay.transform.localScale.x;
        float overlayHeight = cameraRenderOverlay.transform.localScale.y;
        float overlayRadius = cameraRenderOverlay.transform.localScale.z;

#if UNITY_ANDROID
		// Gear VR display panel resolution
		float hmdPanelResWidth = 2560;
		float hmdPanelResHeight = 1440;
#else
        // Rift display panel resolution
        float hmdPanelResWidth = 2160;
        float hmdPanelResHeight = 1200;
#endif

        float singleEyeScreenPhysicalResX = hmdPanelResWidth * 0.5f;
        float singleEyeScreenPhysicalResY = hmdPanelResHeight;

        // Calculate RT Height     
        // screenSizeYInWorld : how much world unity the full screen can cover at overlayQuad's location vertically
        // pixelDensityY: pixels / world unit ( meter )

        float halfFovY = mainCamera.GetComponent<Camera>().fieldOfView / 2;
        float screenSizeYInWorld = 2 * overlayRadius * Mathf.Tan(Mathf.Deg2Rad * halfFovY);
        float pixelDensityYPerWorldUnit = singleEyeScreenPhysicalResY / screenSizeYInWorld;
        float renderTargetHeight = pixelDensityYPerWorldUnit * overlayWidth;

        // Calculate RT width
        float renderTargetWidth = 0.0f;

        // screenSizeXInWorld : how much world unity the full screen can cover at overlayQuad's location horizontally
        // pixelDensityY: pixels / world unit ( meter )

        float screenSizeXInWorld = screenSizeYInWorld * mainCamera.GetComponent<Camera>().aspect;
        float pixelDensityXPerWorldUnit = singleEyeScreenPhysicalResX / screenSizeXInWorld;
        renderTargetWidth = pixelDensityXPerWorldUnit * overlayWidth;

        // Compute the orthographic size for the camera
        float orthographicSize = overlayHeight / 2.0f;
        float orthoCameraAspect = overlayWidth / overlayHeight;
        uiCamera.GetComponent<Camera>().orthographicSize = orthographicSize;
        uiCamera.GetComponent<Camera>().aspect = orthoCameraAspect;

        if (uiCamera.GetComponent<Camera>().targetTexture != null)
            uiCamera.GetComponent<Camera>().targetTexture.Release();

        RenderTexture overlayRT = new RenderTexture(
                (int)renderTargetWidth * 2,
                (int)renderTargetHeight * 2,
                0,
                RenderTextureFormat.ARGB32,
                RenderTextureReadWrite.sRGB);
        Debug.Log("Created RT of resolution w: " + renderTargetWidth + " and h: " + renderTargetHeight);

        overlayRT.hideFlags = HideFlags.DontSave;
        overlayRT.useMipMap = true;
        overlayRT.filterMode = FilterMode.Trilinear;
        overlayRT.anisoLevel = 4;
#if UNITY_5_5_OR_NEWER
        overlayRT.autoGenerateMips = true;
#else
		overlayRT.generateMips = true;
#endif
        uiCamera.GetComponent<Camera>().targetTexture = overlayRT;

        cameraRenderOverlay.textures[0] = overlayRT;
    }

}
