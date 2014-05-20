
namespace System.ComponentModel
{
    public interface INotifyPropertyChanging
    {
        event PropertyChangingEventHandler PropertyChanging;
    }

    public delegate void PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e);

    public class PropertyChangingEventArgs : EventArgs
    {
        string name;

        public PropertyChangingEventArgs(string propertyName)
        {
            name = propertyName;
        }

        public virtual string PropertyName
        {
            get { return name; }
        }
    }
}
