// using UnityEngine;

// [ExecuteInEditMode]
// public class ViewportHandler : MonoBehaviour
// {
//     public float targetWidth = 1280f; //width
//     private Camera cam;

//     void Start()
//     {
//         cam = GetComponent<Camera>();
//     }

//     void Update()
//     {
//         // This calculates the necessary FOV based on the width of the window
//         // rather than the height, preventing the "zoomed-in" crop.
//         float aspect = (float)Screen.width / Screen.height;
//         float targetAspect = targetWidth / 720f; // Assuming 16:9 base

//         if (aspect < targetAspect)
//         {
//             float constantWidthSize = targetAspect / aspect;
//             cam.fieldOfView = 60f * constantWidthSize; // Adjust 60f to your default FOV
//         }
//         else
//         {
//             cam.fieldOfView = 60f;
//         }
//     }
// }







//////////////////////NOTES
///   aspectRatioDevice = (float)screenWidth / screenHeight;
//   aspectRatioUI = (float)1440 / 800;
//   scaleFactor = aspectRatioDevice / aspectRatioUI;

//     public void PositionContainer(Vector2 mousePosition)
//     {

//         float scaledX = mousePosition.x / screenWidth * 1440 * scaleFactor;
//         float scaledY = mousePosition.y / screenHeight * 800;
//         contextMenuVL.style.bottom = scaledY;
//         contextMenuVL.style.left = scaledX;

//     }
    // This code calculates the aspect ratio of the device and compares it to a predefined aspect ratio for the UI (1440x800 in this case). It then computes a scale factor to adjust the UI elements accordingly. When positioning a container based on mouse input, it scales the mouse position to fit within the defined UI dimensions, ensuring that the context menu appears correctly regardless of the device's aspect ratio.