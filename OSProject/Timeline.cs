using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject
{
    public struct ExecuteInstance
    {
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int Duration => EndTime - StartTime;
        public Process Process { get; set; }
    }
    public class Timeline
    {
        public List<ExecuteInstance> Executes;

        public Timeline()
        {
            Executes = new List<ExecuteInstance>();
        }

        public void AddExecution(int start, int end, Process process)
        {
            var ex = new ExecuteInstance {Process = process, StartTime = start, EndTime = end};
            Executes.Add(ex);
        }
    }
}
