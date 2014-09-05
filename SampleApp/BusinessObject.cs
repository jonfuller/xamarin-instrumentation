using Android.Content;

namespace SampleApp
{
    public class BusinessObject
    {
        Context _context;

        public BusinessObject(Context context)
        {
            _context = context;
        }
        public string GetAppName()
        {
            return _context.Resources.GetString (Resource.String.app_name);
        }
    }
}

