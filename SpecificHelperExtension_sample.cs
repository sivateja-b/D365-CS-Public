using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using STB.RESTFulIntegration;

namespace IntegrationExtension
{
    class SpecificHelperExtension : SpecificHelper
    {
        public override IList addObjectToList(object _object, IList List = null)
        {
            switch(_object.GetType().Name)
            {
                case nameof(System.String):
                    System.String str = _object as System.String;
                return this.addObjectToListInternal<System.String>(str, List);
                case nameof(System.DateTime):
                    System.DateTime dt = Convert.ToDateTime(_object);
                return this.addObjectToListInternal<System.DateTime>(dt, List);
                default:
                    throw new Exception("Case unhandled exception. Method name:" + MethodBase.GetCurrentMethod().Name);
            }
        }
        
    }
}
