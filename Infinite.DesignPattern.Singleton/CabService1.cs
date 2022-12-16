using System.Collections.Generic;

namespace Infinite.DesignPattern.Singleton
{
    #region Without Singleton Implementation

    //public class CabService
    //{
    //    private List<string> cabDrivers = new List<string>();
    //    private int count = 0;

    //    public CabService()
    //    {
    //        cabDrivers.AddRange(new string[] { "Rajini", "Kamal", "Vijay", "Ajith" });
    //    }

    //    public string GetNextAvailableDriver()
    //    {
    //        string result = cabDrivers[count];
    //        count++;
    //        if (count >= cabDrivers.Count)
    //        {
    //            count = 0;
    //        }
    //        return result;
    //    }
    //}


    #endregion
    
    public class CabService
    {
        private List<string> cabDrivers = new List<string>();
        private int count = 0;
        private static CabService cabService = new CabService();//Lazy Loading

        public static CabService GetInstance()
        {
            return cabService;
        }

        //Return instance using property
        //public static CabService Instance
        //{
        //    get
        //    {
        //        return cabService;
        //    }
        //}

        private CabService()
        {
            cabDrivers.AddRange(new string[] { "Rajini", "Kamal", "Vijay", "Ajith" });
        }

        public string GetNextAvailableDriver()
        {
            string result = cabDrivers[count];
            count++;
            if (count >= cabDrivers.Count)
            {
                count = 0;
            }
            return result;
        }
    }
}


    
