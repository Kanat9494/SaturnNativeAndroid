namespace SaturnNativeAndroid.Services.Implementations;

public class MenuItemSelectedListener : Java.Lang.Object, NavigationBarView.IOnItemSelectedListener
{
    public bool OnNavigationItemSelected(IMenuItem item)
    {
        switch (item.ItemId)
        {
            case Resource.Id.person:
                return true;
            case Resource.Id.secondFragment:
                return true;
            case Resource.Id.thirdFragment:
                return true;
            default:
                return false;
        }
    }
}
