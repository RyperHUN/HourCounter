using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HabitUtils;

namespace HourCounter
{
    [Serializable]
    class Serializer : ISerializable
    {
        Activity _activityContainer;
        HabitController _habitController;

        public void serializer ()
        {
        }

        public void Save ()
        {

        }

        public void Load ()
        {

        }

        protected Serializer (SerializationInfo info, StreamingContext context)
        {
            _activityContainer = (Activity)info.GetValue ("activityContainer", typeof (Activity));
            _habitController   = (HabitController)info.GetValue ("habitController", typeof (HabitController));
        }
        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("activityContainer", _activityContainer);
            info.AddValue ("habitController", _habitController);
        }
    }
}
