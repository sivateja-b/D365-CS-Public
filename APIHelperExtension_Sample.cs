using System;
using System.Reflection;
using STB.RESTFulIntegration;

namespace IntegrationExtensionSample
{
    public class APIHelperExtension_Sample : APIHelper
    {
        public override object deserializeJSON(string _JSON, Type _responseObjectType)
        {
            object ret = null;
            switch (_responseObjectType.Name)
            {
                case nameof(ResponseModelClass):
                    ret = this.ResponseDeserializeInternal<ResponseModelClass>(_JSON);
                    break;
                default:
                    throw new Exception("Switch doesn't handle the case for: " + _responseObjectType.Name + ". Method name:" + MethodBase.GetCurrentMethod().Name);
            }
            return ret;
        }
    }
}
