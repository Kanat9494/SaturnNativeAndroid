namespace SaturnNativeAndroid.Views.Fragments;

[Activity(Label = "FirstFragment")]
public class FirstFragment : AndroidX.Fragment.App.Fragment
{
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        return inflater.Inflate(Resource.Layout.fragment_first, container, false);
    }
}