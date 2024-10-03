// using UnityEngine;
// using UnityEditor;
// using System.IO;
// using UnityEngine.Networking;
// using System.IO.Compression;
// using System.Threading.Tasks;

// [InitializeOnLoad]
// public class Downloader
// {
//     static Downloader()
//     {
//         _ = Download();
//     }

//     static async Task Download()
//     {
//         string url = "https://drive.google.com/uc?export=download&id=1EHacTHB0algKeSvD8i3mjWCjuy6ntCm9";

//         string folderPath = Path.Combine("Assets", "Firebase");
//         if (!Directory.Exists(folderPath))
//         {
//             Directory.CreateDirectory(folderPath);
//         }


//         if (Directory.GetFiles(folderPath).Length <= 1)
//         {
//             Debug.Log("Downloading Firebase Dependencies...");
//             UnityWebRequest request = UnityWebRequest.Get(url);
//             request.SendWebRequest();
//             while (!request.isDone)
//             {
//                 await Task.Yield();
//             }

//             if (request.result != UnityWebRequest.Result.Success)
//             {
//                 Debug.LogError(request.error);
//             }
//             else
//             {
//                 Debug.Log("Download complete....Installing...");

//                 string tempFolder = Path.Combine(folderPath, "tempzip");
//                 if (!Directory.Exists(tempFolder))
//                 {
//                     Directory.CreateDirectory(tempFolder);
//                 }

//                 string rawfilePath = Path.Combine(tempFolder, "zippp.zip");
//                 if (!File.Exists(rawfilePath))
//                 {
//                     File.WriteAllBytes(rawfilePath, request.downloadHandler.data);
//                     ZipFile.ExtractToDirectory(rawfilePath, folderPath);
//                     Directory.Delete(tempFolder, true);
//                 }
//                 else
//                 {
//                     Directory.Delete(tempFolder, true);
//                 }
//                 request.Dispose();
//                 Debug.Log("... COMPLETED");
//             }
//         }
//         else
//         {
//             Debug.Log("Firebase Already Available");
//         }

//     }
// }
