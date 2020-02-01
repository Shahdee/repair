namespace UnityEngine.UI
{
    [UnityEditor.CustomEditor(typeof(ExtendedButton))]
    public class ExtendedButton_Editor : UnityEditor.UI.ButtonEditor 
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DrawDefaultInspector();
        }
    }
}

