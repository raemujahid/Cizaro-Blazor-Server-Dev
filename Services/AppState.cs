namespace Cizaro_Blazor_Server.Services
{
    public class AppState
    {
        public string SelectedTopBarTab { get; private set; } = string.Empty;

        public event Action OnChange;

        public void SetTopBarSelectedTab(string tabName)
        {
            SelectedTopBarTab = tabName;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
