namespace SaturnNativeAndroid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    BottomNavigationView _bottomNavigationView;
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        _bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);

        _bottomNavigationView.SetOnItemSelectedListener(new MenuItemSelectedListener());
    }
}