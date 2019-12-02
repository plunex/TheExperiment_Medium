using System;

namespace Experiment.Procedure
{
    public class Procedures
    {
        public string getSampleType(object sample){
            return sample.GetType().Name;
        }

    }
}
