# Kogane Quit Application

アプリケーションを終了するためのクラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private void Start()
    {
        QuitApplication.Quit();
    }
}
```