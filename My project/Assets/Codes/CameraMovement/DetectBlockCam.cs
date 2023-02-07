using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectBlockCam : MonoBehaviour, IPointerClickHandler
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
        cameraMovement_.SetNeedPosAndRot(new Vector3(0.6001107f, 1.377729f, 0.2f), Quaternion.Euler(19.594f, 0.366f, -0.01f));
    }
}
