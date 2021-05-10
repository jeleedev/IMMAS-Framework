namespace Immas.Infragistics.BaseForm
{
    public class FormAuthInfo
    {
        public string   ViewId      { get; private set; }
        public string   AuthKind    { get; private set; }
        public bool     Value       { get; private set; }

        public FormAuthInfo(string viewId, string authKind, bool value)
        {
            this.ViewId      = viewId;
            this.AuthKind    = authKind;
            this.Value       = value;
        }

        public override string ToString()
        {
            return $"ViewId: {this.ViewId}, AuthKind: {this.AuthKind}, Value: {this.Value}";
        }
    }
}
