using System;

namespace PP_24_02_25_Annotations
{
    class LegacyAPI
    {
        [Obsolete("Use NewFeature() instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is an old feature");
        }

        public void NewFeature()
        {
            Console.WriteLine("This is the new feature.");
        }
    }

    class Class2
    {
        public static void Main2()
        {
            LegacyAPI api = new LegacyAPI();

            api.OldFeature();
            api.NewFeature();
        }
    }

}
