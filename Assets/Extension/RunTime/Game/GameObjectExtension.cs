using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Extension.RunTime.Game
{
    public static class GameObjectExtension
    {
        public static void DisableAfterSeconds(this GameObject gameObject, float seconds)
        {
            DisableAsync(gameObject, seconds).Forget();
        }

        static async UniTask DisableAsync(this GameObject go, float delay)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(delay), cancellationToken: go.GetCancellationTokenOnDestroy());
            if (go != null) go.SetActive(false);
        }
    }
}