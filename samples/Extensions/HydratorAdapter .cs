namespace LightningTalk.AutoFixture.Extensions
{
    using System;
    using System.Reflection;
    using Foundation.ObjectHydrator.Interfaces;
    using Ploeh.AutoFixture.Kernel;

    public class HydratorAdapter : ISpecimenBuilder
    {
        private readonly IMap map;

        public HydratorAdapter(IMap map)
        {
            if (map == null)
            {
                throw new ArgumentNullException("map");
            }

            this.map = map;
        }

        #region ISpecimenBuilder Members

        public object Create(object request,
            ISpecimenContext context)
        {
            var pi = request as PropertyInfo;
            if (pi == null)
            {
                return new NoSpecimen();
            }

            if (!this.map.Match(pi) || (this.map.Type != pi.PropertyType))
            {
                return new NoSpecimen();
            }

            return this.map.Mapping(pi).Generate();
        }

        #endregion
    }
}