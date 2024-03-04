namespace SaturnNativeAndroid.Views.Fragments;

public class SecondFragment : AndroidX.Fragment.App.Fragment
{
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        return inflater.Inflate(Resource.Layout.fragment_second, container, false);
    }
}
