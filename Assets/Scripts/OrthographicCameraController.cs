///
/// Simple orthographic camera sizing.
///   Author: Dyon Ng (dng@idreaminteractive.com)
///   License: CC0 (http://creativecommons.org/publicdomain/zero/1.0/)
/// 
/// Usage:
/// 
///   You can attach this script to your main camera
///     OR
///   Simply attach this script to any permanent object and fill in the main camera reference
/// 
///   There will be a magenta coloured box denoting a MUST-INCLUDE area.
///   This area is defined by the bounds property.
/// 
/// 

using UnityEngine;

public class OrthographicCameraController : MonoBehaviour
{
    public static OrthographicCameraController Instance
    {
        private set;
        get;
    }

    [Header("References")]

    [SerializeField]
    [Tooltip("You can leave this blank if this script is attached to the main camera.")]
    private Camera mainCamera;

    [SerializeField]
    [Tooltip("Ensures that the area bounds are always in view.")]
    private Vector2 bounds;

    [Space]
    [Header("Constraints")]

    [SerializeField]
    [Tooltip("When you want the the left and right edges of the area to touch the camera edges.")]
    private bool fitWidth = true;

    [SerializeField]
    [Tooltip("When you want the top and bottom edges of the area to touch the camera edges.")]
    private bool fitHeight = true;

    private void Awake()
    {
        if (mainCamera == null)
        {
            mainCamera = GetComponent<Camera>();
        }

        OrthographicCameraController.Instance = this;
        UpdateCameraOrthographicSize();
    }

    public void SetCameraWidth(float width)
    {
        SetCameraSize(width, bounds.y);
    }

    public void SetCameraHeight(float height)
    {
        SetCameraSize(bounds.x, height);
    }

    public void SetCameraSize(float width, float height)
    {
        SetCameraSettings(width, height, fitWidth, fitHeight);
    }

    public void SetFitWidth(bool fitWidth)
    {
        SetFit(fitWidth, this.fitHeight);
    }

    public void SetFitHeight(bool fitHeight)
    {
        SetFit(this.fitWidth, fitHeight);
    }

    public void SetFit(bool fitWidth, bool fitHeight)
    {
        SetCameraSettings(bounds.x, bounds.y, fitWidth, fitHeight);
    }

    public void SetCameraSettings(float width, float height, bool fitWidth, bool fitHeight)
    {
        bounds.x = width;
        bounds.y = width;
        this.fitWidth = fitWidth;
        this.fitHeight = fitHeight;
        UpdateCameraOrthographicSize();
    }

    public void UpdateCameraOrthographicSize()
    {
        float width = bounds.x;
        float height = bounds.y;
        float targetRatio = width / height;
        float screenRatio = (float)Screen.width / (float)Screen.height;

        if (fitWidth && fitHeight)
        {
            if (screenRatio >= targetRatio)
            {
                Camera.main.orthographicSize = height / 2;
            }
            else
            {
                float differenceInSize = targetRatio / screenRatio;
                Camera.main.orthographicSize = height / 2 * differenceInSize;
            }
        }
        else if (fitWidth)
        {
            Camera.main.orthographicSize = width * Screen.height / Screen.width * 0.5f;
        }
        else if (fitHeight)
        {
            Camera.main.orthographicSize = height / 2;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, bounds);
    }
}