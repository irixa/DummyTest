using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataLibrary
{
    public class DummyClass
    {
        public static string GetId(string pxObj)
        {
            //string id = Prefix.Get() + pxObj.ReferenceInfo;
            //id = CompressId.Compress(id);

            string id = pxObj;

            // Sometimes we get sent an application sensor with 'DID[0]', if so then replace it with the
            // correct one which is 'DID[System]' (after compression replace D[0] with D[System])
            if (id.Contains("D[0]"))
            {
                id = id.Replace("D[0]", "D[System]");
            }

            return id;
        }
    }
}
