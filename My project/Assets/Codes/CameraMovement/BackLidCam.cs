using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackLidCam : MonoBehaviour, IPointerClickHandler
{
    private CameraMovement cameraMovement_;
    [SerializeField] private new GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        cameraMovement_ = camera.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        cameraMovement_.SetNeedPosAndRot(new Vector3(0.711f, 1.495f, 1.426f), Quaternion.Euler(20f, -111.833f, 0f));
    }
}
