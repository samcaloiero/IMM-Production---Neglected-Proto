// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
//
// public class CameraCapture : MonoBehaviour
// {
//     public RawImage displayImage;
//
//     public void TakePicture()
//     {
//         NativeCamera.Permission permission = NativeCamera.CheckPermission();
//
//         if (permission == NativeCamera.Permission.Granted)
//         {
//             NativeCamera.RequestPermission();
//         }
//         else if (permission == NativeCamera.Permission.Granted)
//         {
//             //Open Camera to take picture
//             NativeCamera.TakePicture((path)) =>
//             {
//                 Texture2D texture = NativeCamera.LoadImageAtPath(path, 512);
//                 if (texture != null)
//                 {
//                     //Display the texture in the RawImage UI component
//                     displayImage.texture = texture;
//                     Debug.Log("Image path:" + path);
//                 }
//                 else
//                 {
//                     Debug.LogError("Failed to load texture from " + path);
//                 }
//                 else if(permission == NativeCamera.Permission.Denied)
//                 {
//                     Debug.LogWarning("Camera permission denied!");
//                 }
//             }
//         }
//     }
// }
