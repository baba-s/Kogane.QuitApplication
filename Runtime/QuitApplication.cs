using UnityEngine;

namespace Kogane
{
    public static class QuitApplication
    {
        public static void Quit()
        {
            if ( Application.isEditor )
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.ExitPlaymode();
#endif
            }
            else
            {
                Application.Quit();
            }
        }
    }
}