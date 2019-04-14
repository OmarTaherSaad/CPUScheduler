using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject
{
    public class Process
    {
        [DisplayName("Time Arrived")]
        public int ComingTime { get; }
        [DisplayName("Duration")]
        public int Duration { get; }
        [Browsable(false)]
        public int ExecutedTime { get; set; }
        public int Priority { get; }
        [Browsable(false)]
        public int RemainingTime => Duration - ExecutedTime;
        [DisplayName("Finished or not?")]
        public bool Finished
        {
            get => RemainingTime == 0;
        }


        public Process(int comingTime, int duration, int priority = -1)
        {
            ComingTime = comingTime;
            Duration = duration;
            ExecutedTime = 0;
            Priority = priority;
        }
    }
}
