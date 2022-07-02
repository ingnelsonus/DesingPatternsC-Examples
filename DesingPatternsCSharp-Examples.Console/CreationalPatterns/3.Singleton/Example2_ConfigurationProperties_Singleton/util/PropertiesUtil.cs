using System.Configuration;
using System.Collections.Specialized;
using System;

/**
 * @author oblancarte
 */

namespace Example2_Singleton.util{
    public class PropertiesUtil {
        public static NameValueCollection LoadProperty(){
            try {
                NameValueCollection props = null; //ConfigurationManager.AppSettings;
                return props;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}




