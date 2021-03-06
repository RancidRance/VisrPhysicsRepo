﻿using System;
using System.Collections;
using System.IO;
using GLTF;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Net;
using UnityEngine.Networking;
using VertexUnityPlayer;

#if WINDOWS_UWP
using System.Threading.Tasks;
#endif

namespace UnityGLTF.Loader
{
	public class WebRequestLoader : ILoader
	{
		public Stream LoadedStream { get; private set; }

		private string _rootURI;

		public WebRequestLoader(string rootURI)
		{
			_rootURI = rootURI;
		}

		public IEnumerator LoadStream(string gltfFilePath)
		{
			if (gltfFilePath == null)
			{
				throw new ArgumentNullException("gltfFilePath");
			}

			yield return CreateHTTPRequest(_rootURI, gltfFilePath);
		}

		private IEnumerator CreateHTTPRequest(string rootUri, string httpRequestPath)
		{
			UnityWebRequest www = new UnityWebRequest(Path.Combine(rootUri, httpRequestPath), "GET", new DownloadHandlerBuffer(), null);
            www.AddVertexAuth();

#if UNITY_2017_1_OR_NEWER
			yield return www.SendWebRequest();
#else
			yield return www.Send();
#endif
			if ((int)www.responseCode >= 400)
			{
				Debug.LogErrorFormat("{0} - {1}", www.responseCode, www.url);
				throw new Exception("Response code invalid");
			}

			if (www.downloadedBytes > int.MaxValue)
			{
				throw new Exception("Stream is larger than can be copied into byte array");
			}

			LoadedStream = new MemoryStream(www.downloadHandler.data, 0, www.downloadHandler.data.Length, true, true);
		}
	}
}
