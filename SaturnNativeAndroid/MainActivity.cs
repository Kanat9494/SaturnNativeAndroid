using AndroidX.Fragment.App;

namespace SaturnNativeAndroid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    BottomNavigationView? _bottomNavigationView;
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        _bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);

        _bottomNavigationView?.SetOnItemSelectedListener(new MenuItemSelectedListener());

        ReplaceFragment(new FirstFragment());
    }

    private void ReplaceFragment(AndroidX.Fragment.App.Fragment fragment)
    {
        AndroidX.Fragment.App.FragmentManager fragmentManager = SupportFragmentManager;
        AndroidX.Fragment.App.FragmentTransaction transaction = fragmentManager.BeginTransaction();
        transaction.Replace(Resource.Id.flFragment, fragment);
        transaction.Commit();
    }
}