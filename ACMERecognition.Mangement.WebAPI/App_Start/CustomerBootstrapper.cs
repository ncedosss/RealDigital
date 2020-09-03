using ACMERecognition.ManagementService.Common.Extensions;
using Nancy;
using Nancy.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACMERecognition.Mangement.WebAPI.App_Start
{
    public class CustomerBootstrapper : DefaultNancyBootstrapper
    {
        protected override NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                return NancyInternalConfiguration.WithOverrides(
                    c =>
                    {
                        c.Serializers.Remove(c.Serializers.FirstOrDefault());
                        c.Serializers.Insert(0, typeof(JsonNetSerializer));
                    });
            }
        }
    }
}